﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using iFlag.Properties;
using System.Reflection;
//final
namespace iFlag
{
    public partial class mainForm : Form
    {
        // Version
        const string version = "v1.0";
        const bool updatable = false;

        // Embedded firmware version
        const string fwVersion_Major = "1";             // Major version number of the firmware payload
        const string fwVersion_Minor = "3";            // Minor version number

                                                  // In case of special occasions releases,
                                                  // this is what holds the edition string,
                                                  // which features in the window title
        const string edition = "";

        string repositoryURL = "https://github.com/simracer-cz/iFlag";
        string forumThreadURL = "http://members.iracing.com/jforum/posts/list/0/3341549.page";
        string updatesURL = "http://simracer.cz/iflag/updates.xml";
        string donateURL = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=AXVXCF5T3M2GS&item_name=iFLAG&currency_code=USD&source=url";

        bool simConnected;
        bool greeted;                             // Whether the startup greeting has happened
        bool terminating;                         // Turns true when terminating this process/form

        int processNo;                            // Number of the currently running order (1 to X)

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public mainForm()
        {
            processNo = Process.GetProcessesByName("iFlag").Length;
            
            InitializeComponent();

            //this.Text = String.Format("iFLAG{1} {0}", edition, processNo > 1 ? "#" + processNo : "");
            //flagLabel.Text = appMenuItem.Text = String.Format("iFlag {0}", version);
            //this.updatesMenuItem.Visible = updatable;

                                                  // Initialize flag modules
            startCommunication();
            startSDK();
            startMatrix();
            startDispatcher();
            startFlags();
            startOverlays();
            startCar();
            startSession();
            startUpdater();
        }

                                                  // When the window opens,
                                                  // restore persistent user options.
        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!Settings.Default.WindowLocation.IsEmpty)
            {
                this.Location = Settings.Default.WindowLocation;
            }
            else
            {
                System.Drawing.Point screenCenter = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;
                screenCenter.X += System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
                screenCenter.Y += System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
                this.Location = screenCenter;
            }
            this.WindowState = Settings.Default.WindowState;
            //this.TopMost = this.alwaysOnTopMenuItem.Checked = Settings.Default.WindowTopMost;
            this.demoMenuItem.Checked = Settings.Default.DemoMode;
            this.spotterOverlayModuleMenuItem.Checked = Settings.Default.ShowSpotterOverlay;
            this.startLightsModuleMenuItem.Checked = Settings.Default.ShowStartLights;
            this.incidentOverlayModuleMenuItem.Checked = Settings.Default.ShowIncidentOverlay;
            this.pitExitBlueModuleMenuItem.Checked = Settings.Default.ShowPitExitBlue;
            this.closedPitsOverlayModuleMenuItem.Checked = Settings.Default.ShowClosedPitsOverlay;
            this.repairsOverlayModuleMenuItem.Checked = Settings.Default.ShowRepairsOverlay;
            this.pitSpeedLimitModuleMenuItem.Checked = Settings.Default.ShowPitSpeedLimit;

            pitSpeedMap = Settings.Default.PitSpeedMap;
            switch (pitSpeedMap)
            {
                case "safe": pitSpeedMapSafeMenuItem.Checked = true; break;
                case "wide": pitSpeedMapWideMenuItem.Checked = true; break;
                case "narrow": pitSpeedMapNarrowMenuItem.Checked = true; break;
                case "aggressive": pitSpeedMapAggressiveMenuItem.Checked = true; break;
            }

            incidentStyleMap = Settings.Default.IncidentStyleMap;
            switch (incidentStyleMap)
            {
                case "small": incidentStyleMapSmallMenuItem.Checked = true; break;
                case "big": incidentStyleMapBigMenuItem.Checked = true; break;
                case "exploded": incidentStyleMapExplodedMenuItem.Checked = true; break;
            }

            connectorSide = Settings.Default.UsbConnector;
            switch (connectorSide)
            {
                case 0x00: connectorBottomMenuItem.Checked = true; break;
                case 0x01: connectorRightMenuItem.Checked = true; break;
                case 0x02: connectorLeftMenuItem.Checked = true; break;
                case 0x03: connectorTopMenuItem.Checked = true; break;
            }

            matrixLuma = Settings.Default.MatrixLuma;
            switch (matrixLuma)
            {
                case 10: lowBrightnessMenuItem.Checked = true; break;
                case 25: mediumBrightnessMenuItem.Checked = true; break;
                case 60: highBrightnessMenuItem.Checked = true; break;
                case 100: fullBrightnessMenuItem.Checked = true; break;
            }

            updatesLevel = Settings.Default.Updates;
            if (updatesLevel == "stable" || updatesLevel == "experimental")
            {
                //this.updatesEnabledMenuItem.Checked = true;

                if (updatesLevel == "experimental")
                {
                  //  this.updatesExperimentalMenuItem.Checked = true;
                }
            }

            restoreCommunication();

            if (!Settings.Default.AllowMultiple && processNo > 1)
            {
                //multiFlagMessage.Show();
            }

            //Display software version & firmware version
            Version swVersion = Assembly.GetExecutingAssembly().GetName().Version;
            versionLbl.Text = swVersion.Major + "." + swVersion.Minor + "." + fwVersion_Major + "." + fwVersion_Minor;
        }

        // When the window closes,
        // make sure to save all persistent user options.


        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminating = true;
            resetOverlay();
            showFlag(NO_FLAG);

            storeCommunication();

            Settings.Default.WindowState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) Settings.Default.WindowLocation = this.Location;
            Settings.Default.WindowTopMost = this.TopMost;
            Settings.Default.DemoMode = this.demoMenuItem.Checked;
            Settings.Default.ShowSpotterOverlay = this.spotterOverlayModuleMenuItem.Checked;
            Settings.Default.ShowStartLights = this.startLightsModuleMenuItem.Checked;
            Settings.Default.ShowIncidentOverlay = this.incidentOverlayModuleMenuItem.Checked;
            Settings.Default.ShowPitExitBlue = this.pitExitBlueModuleMenuItem.Checked;
            Settings.Default.ShowClosedPitsOverlay = this.closedPitsOverlayModuleMenuItem.Checked;
            Settings.Default.ShowRepairsOverlay = this.repairsOverlayModuleMenuItem.Checked;
            Settings.Default.ShowPitSpeedLimit = this.pitSpeedLimitModuleMenuItem.Checked;
            Settings.Default.PitSpeedMap = pitSpeedMap;
            Settings.Default.IncidentStyleMap = incidentStyleMap;
            Settings.Default.UsbConnector = connectorSide;
            Settings.Default.MatrixLuma = matrixLuma;
            Settings.Default.Updates = updatesLevel;
            Settings.Default.Save();
        }

                                                  // When the window moves,
                                                  // make its new position persistent.
        private void mainForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) Settings.Default.WindowLocation = this.Location;
        }

                                                  // GUI
        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionsMenu.Show(Cursor.Position);
        }


        private void gitMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(repositoryURL);
        }

        private void forumThreadMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(forumThreadURL);
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(donateURL);
        }

        private void demoTimer_Tick(object sender, EventArgs e)
        {
            showDemoFlag();
        }

        private void demoMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default.DemoMode = this.demoMenuItem.Checked;
            demoTimer.Stop();
            demoTimer.Start();
            showDemoFlag();
        }

        private void alwaysOnTopMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default.WindowTopMost = this.TopMost = this.alwaysOnTopMenuItem.Checked;
        }

                                                  // Updates the text labels in the main window
                                                  // with flag and overlay labels
        private void updateSignalLabels()
        {
            flagLabel.Text = flagOnDisplayLabel;
            //overlayLabel.Text = overlaysOnDisplayLabel;

            bool visible = overlaysOnDisplayLabel != "";
            int locationY = visible ? 12 : 18;

            //flagLabel.Location = new System.Drawing.Point(61, locationY);
            //overlayLabel.Visible = visible;
        }

                                                  // Visually indicates the serial connection alive state
                                                  // by changin color of the "Matrix" indicator
                                                  // in the lower left corner of the main form
                                                  //
        private void indicateConnection()
        {
            if (deviceConnected)
            {
                //if (!deviceUpdated())
                //{
                //    updateFirmware();
                //}
                
                {
                    if (!greeted)
                    {
                        greeted = true;
                        showSystemFlag(STARTUP_GREETING, 3);
                        indicateSimConnected(!(simConnected = false));
                        //updateSoftware();
                    }
                    hardwareLight.BackColor = Color.ForestGreen;
                    optionsButton.Enabled = true; 
                    commStatLabel.Text = "Connected " + port;
                    flagLabel.Visible = true ;
                }
            }
            else
            {
                greeted = false;
                hardwareLight.BackColor = Color.LightBlue ;
                optionsButton.Enabled = false;
                commStatLabel.Text = "Seaching for devices...Please wait";
                flagLabel.Visible = false;
                indicateSimConnected(false);
            }

            detectSDK();
        }

                                                  // Visually indicates a running iRacing session
                                                  // in which demo mode gets disabled and telemetry update
                                                  // gets enabled
        private void indicateSimConnected(bool connected)
        {
            if (connected && !simConnected)
            {
                simLight.BackColor = Color.ForestGreen;

                demoMenuItem.Enabled = false;
                demoTimer.Enabled = false;
                updateTimer.Enabled = true;
            }
            else if (!connected && simConnected)
            {
                simLight.BackColor = Color.LightBlue ;

                demoMenuItem.Enabled = true;
                demoTimer.Enabled = true;
                updateTimer.Enabled = false;
                sessionDetected = false;
            }
            simConnected = connected;
        }

        private void connectorMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "connectorBottomMenuItem": connectorSide = 0x00; break;
                case "connectorRightMenuItem":  connectorSide = 0x01; break;
                case "connectorLeftMenuItem":   connectorSide = 0x02; break;
                case "connectorTopMenuItem":    connectorSide = 0x03; break;
            }
            connectorTopMenuItem.Checked = false;
            connectorLeftMenuItem.Checked = false;
            connectorRightMenuItem.Checked = false;
            connectorBottomMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            saveToEEPROM();
            Settings.Default.UsbConnector = connectorSide;
            showSystemFlag(ORIENTATION_CHECK);

        }

        private void brightnessMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "fullBrightnessMenuItem":    matrixLuma = 100; break;
                case "highBrightnessMenuItem":    matrixLuma = 60; break;
                case "mediumBrightnessMenuItem":  matrixLuma = 25; break;
                case "lowBrightnessMenuItem":     matrixLuma = 10; break;
            }
            fullBrightnessMenuItem.Checked = false;
            highBrightnessMenuItem.Checked = false;
            mediumBrightnessMenuItem.Checked = false;
            lowBrightnessMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;

            Settings.Default.MatrixLuma = matrixLuma;
            setMatrixLuma();
            showSystemFlag(LUMA_CHECK);
        }

        private void updatesEnabledMenuItem_Click(object sender, EventArgs e)
        {
            /*if (updatesEnabledMenuItem.Checked)
            {
                updatesEnabledMenuItem.Checked = false;
                updatesExperimentalMenuItem.Enabled = false;
                updatesLevel = "none";
            }
            else
            {
                updatesEnabledMenuItem.Checked = true;
                updatesExperimentalMenuItem.Enabled = true;
                updatesLevel = updatesExperimentalMenuItem.Checked ? "experimental" : "stable";
            }
            Settings.Default.Updates = updatesLevel;
            updateSoftware();
            */
        }

        private void updatesExperimentalMenuItem_Click(object sender, EventArgs e)
        {/*
            if (updatesExperimentalMenuItem.Checked)
            {
                updatesExperimentalMenuItem.Checked = false;
                updatesLevel = "stable";
            }
            else
            {
                updatesExperimentalMenuItem.Checked = true;
                updatesLevel = "experimental";
            }
            Settings.Default.Updates = updatesLevel;
            updateSoftware();
            */
        }

        private void pitSpeedMapMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "pitSpeedMapSafeMenuItem":           pitSpeedMap = "safe"; break;
                case "pitSpeedMapWideMenuItem":           pitSpeedMap = "wide"; break;
                case "pitSpeedMapNarrowMenuItem":         pitSpeedMap = "narrow"; break;
                case "pitSpeedMapAggressiveMenuItem":     pitSpeedMap = "aggressive"; break;
            }
            pitSpeedMapSafeMenuItem.Checked = false;
            pitSpeedMapWideMenuItem.Checked = false;
            pitSpeedMapNarrowMenuItem.Checked = false;
            pitSpeedMapAggressiveMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;

            Settings.Default.PitSpeedMap = pitSpeedMap;
        }

        private void incidentStyleMapMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "incidentStyleMapSmallMenuItem":         incidentStyleMap = "small"; break;
                case "incidentStyleMapBigMenuItem":           incidentStyleMap = "big"; break;
                case "incidentStyleMapExplodedMenuItem":      incidentStyleMap = "exploded"; break;
            }
            incidentStyleMapSmallMenuItem.Checked = false;
            incidentStyleMapBigMenuItem.Checked = false;
            incidentStyleMapExplodedMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;

            Settings.Default.IncidentStyleMap = incidentStyleMap;
        }

        private void multiFlagMessageDismissButton_Click(object sender, EventArgs e)
        {
            //multiFlagMessage.Hide();
            Settings.Default.AllowMultiple = true;
            Settings.Default.Save();
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 5);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            myPen.Color = System.Drawing.Color.Red;
            myPen.Width = 35;
            Rectangle myRectangle = new Rectangle(0, 0, 600, 186);
            graphicsObj.DrawRectangle(myPen, myRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //optionsForm optForm = new optionsForm();
            //optForm.ShowDialog(this);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateFirmware();
        }

        private void minimizeMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

namespace iFlag
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.optionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorLeftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorRightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorBottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotterOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLightsModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapSmallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapBigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapExplodedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitExitBlueModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedPitsOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedLimitModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapSafeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapWideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapNarrowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapAggressiveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.demoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsButton = new System.Windows.Forms.Button();
            this.hardwareLight = new System.Windows.Forms.Label();
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.connectTimer = new System.Windows.Forms.Timer(this.components);
            this.simLight = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.demoTimer = new System.Windows.Forms.Timer(this.components);
            this.initiationTimer = new System.Windows.Forms.Timer(this.components);
            this.clearTimer = new System.Windows.Forms.Timer(this.components);
            this.incidentTimer = new System.Windows.Forms.Timer(this.components);
            this.durationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commStatLabel = new System.Windows.Forms.Label();
            this.flagLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.versionLbl = new System.Windows.Forms.Label();
            this.optionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsMenu
            // 
            this.optionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeMenuItem1,
            this.toolStripSeparator1,
            this.connectorMenuItem,
            this.modulesMenuItem,
            this.brightnessMenuItem,
            this.optionsMenuSeparator,
            this.demoMenuItem,
            this.alwaysOnTopMenuItem});
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(155, 148);
            // 
            // minimizeMenuItem1
            // 
            this.minimizeMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minimizeMenuItem1.Name = "minimizeMenuItem1";
            this.minimizeMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.minimizeMenuItem1.Text = "Minimize";
            this.minimizeMenuItem1.Click += new System.EventHandler(this.minimizeMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // connectorMenuItem
            // 
            this.connectorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectorTopMenuItem,
            this.connectorLeftMenuItem,
            this.connectorRightMenuItem,
            this.connectorBottomMenuItem});
            this.connectorMenuItem.Name = "connectorMenuItem";
            this.connectorMenuItem.Size = new System.Drawing.Size(154, 22);
            this.connectorMenuItem.Text = "USB Connector";
            // 
            // connectorTopMenuItem
            // 
            this.connectorTopMenuItem.CheckOnClick = true;
            this.connectorTopMenuItem.Name = "connectorTopMenuItem";
            this.connectorTopMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorTopMenuItem.Text = "Up";
            this.connectorTopMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces UP";
            this.connectorTopMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorLeftMenuItem
            // 
            this.connectorLeftMenuItem.CheckOnClick = true;
            this.connectorLeftMenuItem.Name = "connectorLeftMenuItem";
            this.connectorLeftMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorLeftMenuItem.Text = "Right";
            this.connectorLeftMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces LEFT";
            this.connectorLeftMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorRightMenuItem
            // 
            this.connectorRightMenuItem.CheckOnClick = true;
            this.connectorRightMenuItem.Name = "connectorRightMenuItem";
            this.connectorRightMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorRightMenuItem.Text = "Left";
            this.connectorRightMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces RIGHT";
            this.connectorRightMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorBottomMenuItem
            // 
            this.connectorBottomMenuItem.CheckOnClick = true;
            this.connectorBottomMenuItem.Name = "connectorBottomMenuItem";
            this.connectorBottomMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorBottomMenuItem.Text = "Down";
            this.connectorBottomMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces DOWN";
            this.connectorBottomMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // modulesMenuItem
            // 
            this.modulesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flagsModuleMenuItem,
            this.spotterOverlayModuleMenuItem,
            this.startLightsModuleMenuItem,
            this.incidentOverlayModuleMenuItem,
            this.pitExitBlueModuleMenuItem,
            this.closedPitsOverlayModuleMenuItem,
            this.repairsOverlayModuleMenuItem,
            this.pitSpeedLimitModuleMenuItem});
            this.modulesMenuItem.Name = "modulesMenuItem";
            this.modulesMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modulesMenuItem.Text = "Modules";
            // 
            // flagsModuleMenuItem
            // 
            this.flagsModuleMenuItem.Checked = true;
            this.flagsModuleMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flagsModuleMenuItem.Enabled = false;
            this.flagsModuleMenuItem.Name = "flagsModuleMenuItem";
            this.flagsModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.flagsModuleMenuItem.Text = "Racing Flags";
            this.flagsModuleMenuItem.ToolTipText = "Show racing flags. Mandatory";
            // 
            // spotterOverlayModuleMenuItem
            // 
            this.spotterOverlayModuleMenuItem.CheckOnClick = true;
            this.spotterOverlayModuleMenuItem.Name = "spotterOverlayModuleMenuItem";
            this.spotterOverlayModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.spotterOverlayModuleMenuItem.Text = "Spotter";
            this.spotterOverlayModuleMenuItem.ToolTipText = "Show spotter\'s traffic calls";
            // 
            // startLightsModuleMenuItem
            // 
            this.startLightsModuleMenuItem.CheckOnClick = true;
            this.startLightsModuleMenuItem.Name = "startLightsModuleMenuItem";
            this.startLightsModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.startLightsModuleMenuItem.Text = "Start Lights";
            this.startLightsModuleMenuItem.ToolTipText = "Show start lights during start of a race";
            // 
            // incidentOverlayModuleMenuItem
            // 
            this.incidentOverlayModuleMenuItem.CheckOnClick = true;
            this.incidentOverlayModuleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentStyleMapMenuItem});
            this.incidentOverlayModuleMenuItem.Name = "incidentOverlayModuleMenuItem";
            this.incidentOverlayModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.incidentOverlayModuleMenuItem.Text = "Incidents";
            this.incidentOverlayModuleMenuItem.ToolTipText = "Show a signal on number of incidents increase";
            // 
            // incidentStyleMapMenuItem
            // 
            this.incidentStyleMapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentStyleMapSmallMenuItem,
            this.incidentStyleMapBigMenuItem,
            this.incidentStyleMapExplodedMenuItem});
            this.incidentStyleMapMenuItem.Name = "incidentStyleMapMenuItem";
            this.incidentStyleMapMenuItem.Size = new System.Drawing.Size(99, 22);
            this.incidentStyleMapMenuItem.Text = "Style";
            // 
            // incidentStyleMapSmallMenuItem
            // 
            this.incidentStyleMapSmallMenuItem.CheckOnClick = true;
            this.incidentStyleMapSmallMenuItem.Name = "incidentStyleMapSmallMenuItem";
            this.incidentStyleMapSmallMenuItem.Size = new System.Drawing.Size(119, 22);
            this.incidentStyleMapSmallMenuItem.Text = "Small";
            this.incidentStyleMapSmallMenuItem.ToolTipText = "Small letter X signal";
            this.incidentStyleMapSmallMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // incidentStyleMapBigMenuItem
            // 
            this.incidentStyleMapBigMenuItem.CheckOnClick = true;
            this.incidentStyleMapBigMenuItem.Name = "incidentStyleMapBigMenuItem";
            this.incidentStyleMapBigMenuItem.Size = new System.Drawing.Size(119, 22);
            this.incidentStyleMapBigMenuItem.Text = "Medium";
            this.incidentStyleMapBigMenuItem.ToolTipText = "Big letter X signal";
            this.incidentStyleMapBigMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // incidentStyleMapExplodedMenuItem
            // 
            this.incidentStyleMapExplodedMenuItem.CheckOnClick = true;
            this.incidentStyleMapExplodedMenuItem.Name = "incidentStyleMapExplodedMenuItem";
            this.incidentStyleMapExplodedMenuItem.Size = new System.Drawing.Size(119, 22);
            this.incidentStyleMapExplodedMenuItem.Text = "Large";
            this.incidentStyleMapExplodedMenuItem.ToolTipText = "Exploded letter X signal";
            this.incidentStyleMapExplodedMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // pitExitBlueModuleMenuItem
            // 
            this.pitExitBlueModuleMenuItem.CheckOnClick = true;
            this.pitExitBlueModuleMenuItem.Name = "pitExitBlueModuleMenuItem";
            this.pitExitBlueModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pitExitBlueModuleMenuItem.Text = "Pit Exit Blue";
            this.pitExitBlueModuleMenuItem.ToolTipText = "Show blue flag on pit exit with fast car within 100 meters behind";
            // 
            // closedPitsOverlayModuleMenuItem
            // 
            this.closedPitsOverlayModuleMenuItem.CheckOnClick = true;
            this.closedPitsOverlayModuleMenuItem.Name = "closedPitsOverlayModuleMenuItem";
            this.closedPitsOverlayModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closedPitsOverlayModuleMenuItem.Text = "Pits Closed";
            this.closedPitsOverlayModuleMenuItem.ToolTipText = "Show signal when pits are closed";
            // 
            // repairsOverlayModuleMenuItem
            // 
            this.repairsOverlayModuleMenuItem.CheckOnClick = true;
            this.repairsOverlayModuleMenuItem.Name = "repairsOverlayModuleMenuItem";
            this.repairsOverlayModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.repairsOverlayModuleMenuItem.Text = "Repairs Progress";
            this.repairsOverlayModuleMenuItem.ToolTipText = "Show signals reflecting progress of repairs in pits";
            // 
            // pitSpeedLimitModuleMenuItem
            // 
            this.pitSpeedLimitModuleMenuItem.CheckOnClick = true;
            this.pitSpeedLimitModuleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pitSpeedMapMenuItem});
            this.pitSpeedLimitModuleMenuItem.Name = "pitSpeedLimitModuleMenuItem";
            this.pitSpeedLimitModuleMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pitSpeedLimitModuleMenuItem.Text = "Pit Speed Limit";
            this.pitSpeedLimitModuleMenuItem.ToolTipText = "Show pit speed limit assistant signals";
            // 
            // pitSpeedMapMenuItem
            // 
            this.pitSpeedMapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pitSpeedMapSafeMenuItem,
            this.pitSpeedMapWideMenuItem,
            this.pitSpeedMapNarrowMenuItem,
            this.pitSpeedMapAggressiveMenuItem});
            this.pitSpeedMapMenuItem.Name = "pitSpeedMapMenuItem";
            this.pitSpeedMapMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pitSpeedMapMenuItem.Text = "Tolerance";
            this.pitSpeedMapMenuItem.ToolTipText = "Adjust the signaling tolerance";
            // 
            // pitSpeedMapSafeMenuItem
            // 
            this.pitSpeedMapSafeMenuItem.CheckOnClick = true;
            this.pitSpeedMapSafeMenuItem.Name = "pitSpeedMapSafeMenuItem";
            this.pitSpeedMapSafeMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pitSpeedMapSafeMenuItem.Text = "Safe";
            this.pitSpeedMapSafeMenuItem.ToolTipText = "Inside -1 to +0 kph range";
            this.pitSpeedMapSafeMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapWideMenuItem
            // 
            this.pitSpeedMapWideMenuItem.CheckOnClick = true;
            this.pitSpeedMapWideMenuItem.Name = "pitSpeedMapWideMenuItem";
            this.pitSpeedMapWideMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pitSpeedMapWideMenuItem.Text = "Wide";
            this.pitSpeedMapWideMenuItem.ToolTipText = "Inside -1 to +1 kph range";
            this.pitSpeedMapWideMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapNarrowMenuItem
            // 
            this.pitSpeedMapNarrowMenuItem.CheckOnClick = true;
            this.pitSpeedMapNarrowMenuItem.Name = "pitSpeedMapNarrowMenuItem";
            this.pitSpeedMapNarrowMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pitSpeedMapNarrowMenuItem.Text = "Narrow";
            this.pitSpeedMapNarrowMenuItem.ToolTipText = "Inside -0.5 to +0.5 kph range";
            this.pitSpeedMapNarrowMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapAggressiveMenuItem
            // 
            this.pitSpeedMapAggressiveMenuItem.CheckOnClick = true;
            this.pitSpeedMapAggressiveMenuItem.Name = "pitSpeedMapAggressiveMenuItem";
            this.pitSpeedMapAggressiveMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pitSpeedMapAggressiveMenuItem.Text = "Close";
            this.pitSpeedMapAggressiveMenuItem.ToolTipText = "Inside -0 and +1 kph range";
            this.pitSpeedMapAggressiveMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // brightnessMenuItem
            // 
            this.brightnessMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullBrightnessMenuItem,
            this.highBrightnessMenuItem,
            this.mediumBrightnessMenuItem,
            this.lowBrightnessMenuItem});
            this.brightnessMenuItem.Name = "brightnessMenuItem";
            this.brightnessMenuItem.Size = new System.Drawing.Size(154, 22);
            this.brightnessMenuItem.Text = "Brightness";
            // 
            // fullBrightnessMenuItem
            // 
            this.fullBrightnessMenuItem.CheckOnClick = true;
            this.fullBrightnessMenuItem.Name = "fullBrightnessMenuItem";
            this.fullBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fullBrightnessMenuItem.Text = "Full";
            this.fullBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // highBrightnessMenuItem
            // 
            this.highBrightnessMenuItem.CheckOnClick = true;
            this.highBrightnessMenuItem.Name = "highBrightnessMenuItem";
            this.highBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.highBrightnessMenuItem.Text = "High";
            this.highBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // mediumBrightnessMenuItem
            // 
            this.mediumBrightnessMenuItem.CheckOnClick = true;
            this.mediumBrightnessMenuItem.Name = "mediumBrightnessMenuItem";
            this.mediumBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumBrightnessMenuItem.Text = "Medium";
            this.mediumBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // lowBrightnessMenuItem
            // 
            this.lowBrightnessMenuItem.CheckOnClick = true;
            this.lowBrightnessMenuItem.Name = "lowBrightnessMenuItem";
            this.lowBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lowBrightnessMenuItem.Text = "Low";
            this.lowBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // optionsMenuSeparator
            // 
            this.optionsMenuSeparator.Name = "optionsMenuSeparator";
            this.optionsMenuSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // demoMenuItem
            // 
            this.demoMenuItem.Checked = true;
            this.demoMenuItem.CheckOnClick = true;
            this.demoMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.demoMenuItem.Name = "demoMenuItem";
            this.demoMenuItem.Size = new System.Drawing.Size(154, 22);
            this.demoMenuItem.Text = "Demo Mode";
            this.demoMenuItem.ToolTipText = "Only when not in iRacing session. Cycles some of the flags for amusement";
            this.demoMenuItem.CheckStateChanged += new System.EventHandler(this.demoMenuItem_CheckStateChanged);
            // 
            // alwaysOnTopMenuItem
            // 
            this.alwaysOnTopMenuItem.Checked = true;
            this.alwaysOnTopMenuItem.CheckOnClick = true;
            this.alwaysOnTopMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopMenuItem.Name = "alwaysOnTopMenuItem";
            this.alwaysOnTopMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alwaysOnTopMenuItem.Text = "Always on Top";
            this.alwaysOnTopMenuItem.ToolTipText = "Keep this window on top of other windows";
            this.alwaysOnTopMenuItem.CheckStateChanged += new System.EventHandler(this.alwaysOnTopMenuItem_CheckStateChanged);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Red;
            this.optionsButton.Enabled = false;
            this.optionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.optionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.optionsButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(264, 95);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(178, 40);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.Text = "MENU";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // hardwareLight
            // 
            this.hardwareLight.BackColor = System.Drawing.Color.LightBlue;
            this.hardwareLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hardwareLight.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareLight.ForeColor = System.Drawing.Color.White;
            this.hardwareLight.Location = new System.Drawing.Point(217, 104);
            this.hardwareLight.Name = "hardwareLight";
            this.hardwareLight.Size = new System.Drawing.Size(20, 20);
            this.hardwareLight.TabIndex = 3;
            this.hardwareLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Interval = 5000;
            this.timeoutTimer.Tick += new System.EventHandler(this.timeoutTimer_Tick);
            // 
            // connectTimer
            // 
            this.connectTimer.Enabled = true;
            this.connectTimer.Interval = 3000;
            this.connectTimer.Tick += new System.EventHandler(this.connectTimer_Tick);
            // 
            // simLight
            // 
            this.simLight.BackColor = System.Drawing.Color.LightBlue;
            this.simLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simLight.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simLight.ForeColor = System.Drawing.Color.White;
            this.simLight.Location = new System.Drawing.Point(217, 139);
            this.simLight.Name = "simLight";
            this.simLight.Size = new System.Drawing.Size(20, 20);
            this.simLight.TabIndex = 4;
            this.simLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 50;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // demoTimer
            // 
            this.demoTimer.Interval = 5000;
            this.demoTimer.Tick += new System.EventHandler(this.demoTimer_Tick);
            // 
            // initiationTimer
            // 
            this.initiationTimer.Enabled = true;
            this.initiationTimer.Interval = 10000;
            this.initiationTimer.Tick += new System.EventHandler(this.initiationTimer_Tick);
            // 
            // clearTimer
            // 
            this.clearTimer.Interval = 3000;
            this.clearTimer.Tick += new System.EventHandler(this.clearTimer_Tick);
            // 
            // incidentTimer
            // 
            this.incidentTimer.Interval = 3000;
            this.incidentTimer.Tick += new System.EventHandler(this.incidentTimer_Tick);
            // 
            // durationTimer
            // 
            this.durationTimer.Interval = 2000;
            this.durationTimer.Tick += new System.EventHandler(this.durationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CONNECTED TO iFLAG      .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CONNECTED TO iRACING   .";
            // 
            // commStatLabel
            // 
            this.commStatLabel.AutoSize = true;
            this.commStatLabel.BackColor = System.Drawing.Color.Red;
            this.commStatLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commStatLabel.Location = new System.Drawing.Point(8, 168);
            this.commStatLabel.Name = "commStatLabel";
            this.commStatLabel.Size = new System.Drawing.Size(188, 13);
            this.commStatLabel.TabIndex = 15;
            this.commStatLabel.Text = "Seaching for devices...Please wait";
            // 
            // flagLabel
            // 
            this.flagLabel.BackColor = System.Drawing.Color.Red;
            this.flagLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagLabel.Location = new System.Drawing.Point(276, 169);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(190, 13);
            this.flagLabel.TabIndex = 16;
            this.flagLabel.Text = "--";
            this.flagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(451, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(264, 139);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(70, 21);
            this.cmbComPort.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 21);
            this.button2.TabIndex = 21;
            this.button2.Text = "FW DOWNLOAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.versionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.ForeColor = System.Drawing.Color.LightGray;
            this.versionLbl.Location = new System.Drawing.Point(8, 45);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(40, 13);
            this.versionLbl.TabIndex = 22;
            this.versionLbl.Text = "1.0.1.2";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(470, 184);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.simLight);
            this.Controls.Add(this.hardwareLight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbComPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.commStatLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "iRacingiFlag";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.Move += new System.EventHandler(this.mainForm_Move);
            this.optionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopMenuItem;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Label hardwareLight;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Timer connectTimer;
        private System.Windows.Forms.Label simLight;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer demoTimer;
        private System.Windows.Forms.ToolStripMenuItem demoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorLeftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorRightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorBottomMenuItem;
        private System.Windows.Forms.ToolStripSeparator optionsMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem modulesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flagsModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startLightsModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotterOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapSmallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapBigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapExplodedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitExitBlueModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedPitsOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairsOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedLimitModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapSafeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapWideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapNarrowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapAggressiveMenuItem;
        private System.Windows.Forms.Timer initiationTimer;
        private System.Windows.Forms.Timer clearTimer;
        private System.Windows.Forms.Timer durationTimer;
        private System.Windows.Forms.Timer incidentTimer;
        private System.Windows.Forms.ToolStripMenuItem brightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowBrightnessMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label commStatLabel;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem minimizeMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label versionLbl;
    }
}


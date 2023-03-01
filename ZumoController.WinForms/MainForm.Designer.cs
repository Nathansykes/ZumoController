namespace ZumoController.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            XboxInputTimer = new System.Windows.Forms.Timer(components);
            XboxInputBtn = new MetroFramework.Controls.MetroTile();
            SerialReadTextbox = new TextBox();
            ReadSerialTimer = new System.Windows.Forms.Timer(components);
            TabControl = new TabControl();
            CommandsTab = new TabPage();
            SendCommandBtn = new MetroFramework.Controls.MetroButton();
            CommandTextBox = new TextBox();
            WASDTab = new TabPage();
            WASDModeLabel = new MetroFramework.Controls.MetroLabel();
            WASDModeToggle = new MetroFramework.Controls.MetroToggle();
            PressedKeyLabel = new Label();
            KeyControlBtn = new MetroFramework.Controls.MetroTile();
            SpeedLabel = new MetroFramework.Controls.MetroLabel();
            SpeedTrackBar = new TrackBar();
            XboxTab = new TabPage();
            XboxModeLabel = new MetroFramework.Controls.MetroLabel();
            XboxControlToggle = new MetroFramework.Controls.MetroToggle();
            ControllerLabel = new MetroFramework.Controls.MetroLabel();
            StickLabel = new MetroFramework.Controls.MetroLabel();
            LTLabel = new MetroFramework.Controls.MetroLabel();
            RTLabel = new MetroFramework.Controls.MetroLabel();
            AutomatedTab = new TabPage();
            SemiAutoModeLabel = new MetroFramework.Controls.MetroLabel();
            SemiAutoModeToggle = new MetroFramework.Controls.MetroToggle();
            FullAutoModeLabel = new MetroFramework.Controls.MetroLabel();
            FullAutoModeToggle = new MetroFramework.Controls.MetroToggle();
            settingsTab = new TabPage();
            SaveSettingsTile = new MetroFramework.Controls.MetroTile();
            RefreshPortsBtn = new MetroFramework.Controls.MetroButton();
            PortComboBox = new MetroFramework.Controls.MetroComboBox();
            PortLabel = new MetroFramework.Controls.MetroLabel();
            BaudLabel = new MetroFramework.Controls.MetroLabel();
            BaudTextBox = new TextBox();
            OpenPortBtn = new MetroFramework.Controls.MetroTile();
            TabControl.SuspendLayout();
            CommandsTab.SuspendLayout();
            WASDTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).BeginInit();
            XboxTab.SuspendLayout();
            AutomatedTab.SuspendLayout();
            settingsTab.SuspendLayout();
            SuspendLayout();
            // 
            // XboxInputTimer
            // 
            XboxInputTimer.Interval = 25;
            XboxInputTimer.Tick += XboxInputTimer_Tick;
            // 
            // XboxInputBtn
            // 
            XboxInputBtn.ActiveControl = null;
            XboxInputBtn.Location = new Point(3, 28);
            XboxInputBtn.Name = "XboxInputBtn";
            XboxInputBtn.Size = new Size(165, 45);
            XboxInputBtn.TabIndex = 0;
            XboxInputBtn.Text = "Enable Xbox Input";
            XboxInputBtn.TextAlign = ContentAlignment.MiddleCenter;
            XboxInputBtn.UseSelectable = true;
            XboxInputBtn.Click += XboxInputBtn_Click;
            // 
            // SerialReadTextbox
            // 
            SerialReadTextbox.Location = new Point(806, 53);
            SerialReadTextbox.Multiline = true;
            SerialReadTextbox.Name = "SerialReadTextbox";
            SerialReadTextbox.Size = new Size(284, 455);
            SerialReadTextbox.TabIndex = 4;
            // 
            // ReadSerialTimer
            // 
            ReadSerialTimer.Tick += ReadSerialTimer_Tick;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(CommandsTab);
            TabControl.Controls.Add(WASDTab);
            TabControl.Controls.Add(XboxTab);
            TabControl.Controls.Add(AutomatedTab);
            TabControl.Controls.Add(settingsTab);
            TabControl.HotTrack = true;
            TabControl.ItemSize = new Size(156, 20);
            TabControl.Location = new Point(12, 53);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(785, 455);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabIndex = 5;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // CommandsTab
            // 
            CommandsTab.Controls.Add(SendCommandBtn);
            CommandsTab.Controls.Add(CommandTextBox);
            CommandsTab.Location = new Point(4, 24);
            CommandsTab.Name = "CommandsTab";
            CommandsTab.Padding = new Padding(3);
            CommandsTab.Size = new Size(777, 427);
            CommandsTab.TabIndex = 0;
            CommandsTab.Text = "Commands";
            CommandsTab.UseVisualStyleBackColor = true;
            // 
            // SendCommandBtn
            // 
            SendCommandBtn.Location = new Point(557, 48);
            SendCommandBtn.Name = "SendCommandBtn";
            SendCommandBtn.Size = new Size(204, 29);
            SendCommandBtn.TabIndex = 1;
            SendCommandBtn.Text = "Send";
            SendCommandBtn.UseSelectable = true;
            SendCommandBtn.Click += SendCommandBtn_Click;
            // 
            // CommandTextBox
            // 
            CommandTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CommandTextBox.Location = new Point(19, 48);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new Size(532, 29);
            CommandTextBox.TabIndex = 0;
            // 
            // WASDTab
            // 
            WASDTab.Controls.Add(WASDModeLabel);
            WASDTab.Controls.Add(WASDModeToggle);
            WASDTab.Controls.Add(PressedKeyLabel);
            WASDTab.Controls.Add(KeyControlBtn);
            WASDTab.Controls.Add(SpeedLabel);
            WASDTab.Controls.Add(SpeedTrackBar);
            WASDTab.Location = new Point(4, 24);
            WASDTab.Name = "WASDTab";
            WASDTab.Padding = new Padding(3);
            WASDTab.Size = new Size(777, 427);
            WASDTab.TabIndex = 1;
            WASDTab.Text = "Key Control";
            WASDTab.UseVisualStyleBackColor = true;
            // 
            // WASDModeLabel
            // 
            WASDModeLabel.AutoSize = true;
            WASDModeLabel.Location = new Point(3, 3);
            WASDModeLabel.Name = "WASDModeLabel";
            WASDModeLabel.Size = new Size(113, 19);
            WASDModeLabel.TabIndex = 5;
            WASDModeLabel.Text = "Enable this Mode:";
            // 
            // WASDModeToggle
            // 
            WASDModeToggle.AutoSize = true;
            WASDModeToggle.Location = new Point(122, 3);
            WASDModeToggle.Name = "WASDModeToggle";
            WASDModeToggle.Size = new Size(80, 19);
            WASDModeToggle.TabIndex = 4;
            WASDModeToggle.Text = "Off";
            WASDModeToggle.UseSelectable = true;
            WASDModeToggle.CheckedChanged += WASDModeToggle_CheckedChanged;
            // 
            // PressedKeyLabel
            // 
            PressedKeyLabel.AutoSize = true;
            PressedKeyLabel.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            PressedKeyLabel.Location = new Point(265, 188);
            PressedKeyLabel.Name = "PressedKeyLabel";
            PressedKeyLabel.Size = new Size(99, 51);
            PressedKeyLabel.TabIndex = 3;
            PressedKeyLabel.Text = "Key: ";
            // 
            // KeyControlBtn
            // 
            KeyControlBtn.ActiveControl = null;
            KeyControlBtn.Location = new Point(3, 28);
            KeyControlBtn.Name = "KeyControlBtn";
            KeyControlBtn.Size = new Size(165, 45);
            KeyControlBtn.TabIndex = 2;
            KeyControlBtn.Text = "Enable Key Capture";
            KeyControlBtn.TextAlign = ContentAlignment.MiddleCenter;
            KeyControlBtn.UseSelectable = true;
            KeyControlBtn.Click += KeyControlBtn_Click;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(708, 5);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(60, 19);
            SpeedLabel.TabIndex = 1;
            SpeedLabel.Text = "Speed: 0";
            // 
            // SpeedTrackBar
            // 
            SpeedTrackBar.BackColor = Color.White;
            SpeedTrackBar.LargeChange = 50;
            SpeedTrackBar.Location = new Point(726, 25);
            SpeedTrackBar.Maximum = 400;
            SpeedTrackBar.Name = "SpeedTrackBar";
            SpeedTrackBar.Orientation = Orientation.Vertical;
            SpeedTrackBar.Size = new Size(45, 396);
            SpeedTrackBar.SmallChange = 10;
            SpeedTrackBar.TabIndex = 0;
            SpeedTrackBar.TickFrequency = 10;
            SpeedTrackBar.Scroll += SpeedTrackBar_Scroll;
            // 
            // XboxTab
            // 
            XboxTab.Controls.Add(XboxModeLabel);
            XboxTab.Controls.Add(XboxControlToggle);
            XboxTab.Controls.Add(ControllerLabel);
            XboxTab.Controls.Add(StickLabel);
            XboxTab.Controls.Add(LTLabel);
            XboxTab.Controls.Add(RTLabel);
            XboxTab.Controls.Add(XboxInputBtn);
            XboxTab.Location = new Point(4, 24);
            XboxTab.Name = "XboxTab";
            XboxTab.Size = new Size(777, 427);
            XboxTab.TabIndex = 2;
            XboxTab.Text = "Xbox Control";
            XboxTab.UseVisualStyleBackColor = true;
            // 
            // XboxModeLabel
            // 
            XboxModeLabel.AutoSize = true;
            XboxModeLabel.Location = new Point(3, 3);
            XboxModeLabel.Name = "XboxModeLabel";
            XboxModeLabel.Size = new Size(110, 19);
            XboxModeLabel.TabIndex = 7;
            XboxModeLabel.Text = "Enable this Mode";
            // 
            // XboxControlToggle
            // 
            XboxControlToggle.AutoSize = true;
            XboxControlToggle.Location = new Point(119, 3);
            XboxControlToggle.Name = "XboxControlToggle";
            XboxControlToggle.Size = new Size(80, 19);
            XboxControlToggle.TabIndex = 6;
            XboxControlToggle.Text = "Off";
            XboxControlToggle.UseSelectable = true;
            XboxControlToggle.CheckedChanged += XboxControlToggle_CheckedChanged;
            // 
            // ControllerLabel
            // 
            ControllerLabel.AutoSize = true;
            ControllerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            ControllerLabel.Location = new Point(230, 14);
            ControllerLabel.Name = "ControllerLabel";
            ControllerLabel.Size = new Size(127, 25);
            ControllerLabel.TabIndex = 4;
            ControllerLabel.Text = "Not Connected";
            // 
            // StickLabel
            // 
            StickLabel.AutoSize = true;
            StickLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            StickLabel.Location = new Point(230, 221);
            StickLabel.Name = "StickLabel";
            StickLabel.Size = new Size(96, 25);
            StickLabel.TabIndex = 3;
            StickLabel.Text = "Stick Value:";
            // 
            // LTLabel
            // 
            LTLabel.AutoSize = true;
            LTLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            LTLabel.Location = new Point(230, 185);
            LTLabel.Name = "LTLabel";
            LTLabel.Size = new Size(101, 25);
            LTLabel.TabIndex = 2;
            LTLabel.Text = "Left Trigger:";
            // 
            // RTLabel
            // 
            RTLabel.AutoSize = true;
            RTLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            RTLabel.Location = new Point(230, 150);
            RTLabel.Name = "RTLabel";
            RTLabel.Size = new Size(113, 25);
            RTLabel.TabIndex = 1;
            RTLabel.Text = "Right Trigger:";
            // 
            // AutomatedTab
            // 
            AutomatedTab.Controls.Add(SemiAutoModeLabel);
            AutomatedTab.Controls.Add(SemiAutoModeToggle);
            AutomatedTab.Controls.Add(FullAutoModeLabel);
            AutomatedTab.Controls.Add(FullAutoModeToggle);
            AutomatedTab.Location = new Point(4, 24);
            AutomatedTab.Name = "AutomatedTab";
            AutomatedTab.Size = new Size(777, 427);
            AutomatedTab.TabIndex = 3;
            AutomatedTab.Text = "Automated";
            AutomatedTab.UseVisualStyleBackColor = true;
            // 
            // SemiAutoModeLabel
            // 
            SemiAutoModeLabel.AutoSize = true;
            SemiAutoModeLabel.Location = new Point(4, 30);
            SemiAutoModeLabel.Name = "SemiAutoModeLabel";
            SemiAutoModeLabel.Size = new Size(148, 19);
            SemiAutoModeLabel.TabIndex = 12;
            SemiAutoModeLabel.Text = "Enable Semi Automatic:";
            // 
            // SemiAutoModeToggle
            // 
            SemiAutoModeToggle.AutoSize = true;
            SemiAutoModeToggle.Location = new Point(152, 30);
            SemiAutoModeToggle.Name = "SemiAutoModeToggle";
            SemiAutoModeToggle.Size = new Size(80, 19);
            SemiAutoModeToggle.TabIndex = 11;
            SemiAutoModeToggle.Text = "Off";
            SemiAutoModeToggle.UseSelectable = true;
            SemiAutoModeToggle.CheckedChanged += SemiAutoModeToggle_CheckedChanged;
            // 
            // FullAutoModeLabel
            // 
            FullAutoModeLabel.AutoSize = true;
            FullAutoModeLabel.Location = new Point(4, 5);
            FullAutoModeLabel.Name = "FullAutoModeLabel";
            FullAutoModeLabel.Size = new Size(145, 19);
            FullAutoModeLabel.TabIndex = 10;
            FullAutoModeLabel.Text = "Enable Fully Automatic:";
            // 
            // FullAutoModeToggle
            // 
            FullAutoModeToggle.AutoSize = true;
            FullAutoModeToggle.Location = new Point(152, 5);
            FullAutoModeToggle.Name = "FullAutoModeToggle";
            FullAutoModeToggle.Size = new Size(80, 19);
            FullAutoModeToggle.TabIndex = 9;
            FullAutoModeToggle.Text = "Off";
            FullAutoModeToggle.UseSelectable = true;
            FullAutoModeToggle.CheckedChanged += FullAutoModeToggle_CheckedChanged;
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(SaveSettingsTile);
            settingsTab.Controls.Add(RefreshPortsBtn);
            settingsTab.Controls.Add(PortComboBox);
            settingsTab.Controls.Add(PortLabel);
            settingsTab.Controls.Add(BaudLabel);
            settingsTab.Controls.Add(BaudTextBox);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Name = "settingsTab";
            settingsTab.Size = new Size(777, 427);
            settingsTab.TabIndex = 4;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsTile
            // 
            SaveSettingsTile.ActiveControl = null;
            SaveSettingsTile.Location = new Point(212, 116);
            SaveSettingsTile.Name = "SaveSettingsTile";
            SaveSettingsTile.Size = new Size(131, 50);
            SaveSettingsTile.TabIndex = 6;
            SaveSettingsTile.Text = "Save Settings";
            SaveSettingsTile.TextAlign = ContentAlignment.MiddleCenter;
            SaveSettingsTile.UseSelectable = true;
            SaveSettingsTile.Click += SaveSettingsTile_Click;
            // 
            // RefreshPortsBtn
            // 
            RefreshPortsBtn.Location = new Point(283, 20);
            RefreshPortsBtn.Name = "RefreshPortsBtn";
            RefreshPortsBtn.Size = new Size(60, 29);
            RefreshPortsBtn.TabIndex = 9;
            RefreshPortsBtn.Text = "Refresh";
            RefreshPortsBtn.UseSelectable = true;
            RefreshPortsBtn.Click += RefreshPortsBtn_Click;
            // 
            // PortComboBox
            // 
            PortComboBox.FormattingEnabled = true;
            PortComboBox.ItemHeight = 23;
            PortComboBox.Location = new Point(94, 20);
            PortComboBox.Name = "PortComboBox";
            PortComboBox.Size = new Size(173, 29);
            PortComboBox.TabIndex = 8;
            PortComboBox.UseSelectable = true;
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(54, 24);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(37, 19);
            PortLabel.TabIndex = 6;
            PortLabel.Text = "Port:";
            PortLabel.UseCustomBackColor = true;
            // 
            // BaudLabel
            // 
            BaudLabel.AutoSize = true;
            BaudLabel.Location = new Point(19, 65);
            BaudLabel.Name = "BaudLabel";
            BaudLabel.Size = new Size(72, 19);
            BaudLabel.TabIndex = 7;
            BaudLabel.Text = "Baud Rate:";
            BaudLabel.UseCustomBackColor = true;
            // 
            // BaudTextBox
            // 
            BaudTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            BaudTextBox.Location = new Point(94, 64);
            BaudTextBox.Name = "BaudTextBox";
            BaudTextBox.Size = new Size(173, 23);
            BaudTextBox.TabIndex = 5;
            // 
            // OpenPortBtn
            // 
            OpenPortBtn.ActiveControl = null;
            OpenPortBtn.Location = new Point(980, 6);
            OpenPortBtn.Name = "OpenPortBtn";
            OpenPortBtn.Size = new Size(110, 41);
            OpenPortBtn.TabIndex = 6;
            OpenPortBtn.Text = "Re-Open Port";
            OpenPortBtn.TextAlign = ContentAlignment.MiddleCenter;
            OpenPortBtn.UseSelectable = true;
            OpenPortBtn.Click += OpenPortBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 530);
            Controls.Add(OpenPortBtn);
            Controls.Add(TabControl);
            Controls.Add(SerialReadTextbox);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Zumo Controller";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            TabControl.ResumeLayout(false);
            CommandsTab.ResumeLayout(false);
            CommandsTab.PerformLayout();
            WASDTab.ResumeLayout(false);
            WASDTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).EndInit();
            XboxTab.ResumeLayout(false);
            XboxTab.PerformLayout();
            AutomatedTab.ResumeLayout(false);
            AutomatedTab.PerformLayout();
            settingsTab.ResumeLayout(false);
            settingsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer XboxInputTimer;
        private MetroFramework.Controls.MetroTile XboxInputBtn;
        private TextBox SerialReadTextbox;
        private System.Windows.Forms.Timer ReadSerialTimer;
        private TabControl TabControl;
        private TabPage CommandsTab;
        private TabPage WASDTab;
        private TabPage XboxTab;
        private TabPage AutomatedTab;
        private TabPage settingsTab;
        private MetroFramework.Controls.MetroButton RefreshPortsBtn;
        private MetroFramework.Controls.MetroComboBox PortComboBox;
        private MetroFramework.Controls.MetroLabel PortLabel;
        private MetroFramework.Controls.MetroLabel BaudLabel;
        private TextBox BaudTextBox;
        private MetroFramework.Controls.MetroTile SaveSettingsTile;
        private MetroFramework.Controls.MetroLabel SpeedLabel;
        private TrackBar SpeedTrackBar;
        private MetroFramework.Controls.MetroTile KeyControlBtn;
        private Label PressedKeyLabel;
        private MetroFramework.Controls.MetroTile OpenPortBtn;
        private TextBox CommandTextBox;
        private MetroFramework.Controls.MetroButton SendCommandBtn;
        private MetroFramework.Controls.MetroLabel StickLabel;
        private MetroFramework.Controls.MetroLabel LTLabel;
        private MetroFramework.Controls.MetroLabel RTLabel;
        private MetroFramework.Controls.MetroLabel ControllerLabel;
        private MetroFramework.Controls.MetroLabel WASDModeLabel;
        private MetroFramework.Controls.MetroToggle WASDModeToggle;
        private MetroFramework.Controls.MetroLabel XboxModeLabel;
        private MetroFramework.Controls.MetroToggle XboxControlToggle;
        private MetroFramework.Controls.MetroLabel SemiAutoModeLabel;
        private MetroFramework.Controls.MetroToggle SemiAutoModeToggle;
        private MetroFramework.Controls.MetroLabel FullAutoModeLabel;
        private MetroFramework.Controls.MetroToggle FullAutoModeToggle;
    }
}
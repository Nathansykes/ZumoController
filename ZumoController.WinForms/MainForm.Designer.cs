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
            this.components = new System.ComponentModel.Container();
            this.XboxInputTimer = new System.Windows.Forms.Timer(this.components);
            this.XboxInputBtn = new MetroFramework.Controls.MetroTile();
            this.SerialReadTextbox = new System.Windows.Forms.TextBox();
            this.ReadSerialTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CommandsTab = new System.Windows.Forms.TabPage();
            this.SendCommandBtn = new MetroFramework.Controls.MetroButton();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.WASDTab = new System.Windows.Forms.TabPage();
            this.PressedKeyLabel = new System.Windows.Forms.Label();
            this.KeyControlBtn = new MetroFramework.Controls.MetroTile();
            this.SpeedLabel = new MetroFramework.Controls.MetroLabel();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.XboxTab = new System.Windows.Forms.TabPage();
            this.StickLabel = new MetroFramework.Controls.MetroLabel();
            this.LTLabel = new MetroFramework.Controls.MetroLabel();
            this.RTLabel = new MetroFramework.Controls.MetroLabel();
            this.AutomatedTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.SaveSettingsTile = new MetroFramework.Controls.MetroTile();
            this.RefreshPortsBtn = new MetroFramework.Controls.MetroButton();
            this.PortComboBox = new MetroFramework.Controls.MetroComboBox();
            this.PortLabel = new MetroFramework.Controls.MetroLabel();
            this.BaudLabel = new MetroFramework.Controls.MetroLabel();
            this.BaudTextBox = new System.Windows.Forms.TextBox();
            this.OpenPortBtn = new MetroFramework.Controls.MetroTile();
            this.ControllerLabel = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.CommandsTab.SuspendLayout();
            this.WASDTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.XboxTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // XboxInputTimer
            // 
            this.XboxInputTimer.Interval = 25;
            this.XboxInputTimer.Tick += new System.EventHandler(this.XboxInputTimer_Tick);
            // 
            // XboxInputBtn
            // 
            this.XboxInputBtn.ActiveControl = null;
            this.XboxInputBtn.Location = new System.Drawing.Point(3, 3);
            this.XboxInputBtn.Name = "XboxInputBtn";
            this.XboxInputBtn.Size = new System.Drawing.Size(165, 45);
            this.XboxInputBtn.TabIndex = 0;
            this.XboxInputBtn.Text = "Enable Xbox Input";
            this.XboxInputBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XboxInputBtn.UseSelectable = true;
            this.XboxInputBtn.Click += new System.EventHandler(this.XboxInputBtn_Click);
            // 
            // SerialReadTextbox
            // 
            this.SerialReadTextbox.Location = new System.Drawing.Point(806, 53);
            this.SerialReadTextbox.Multiline = true;
            this.SerialReadTextbox.Name = "SerialReadTextbox";
            this.SerialReadTextbox.Size = new System.Drawing.Size(284, 455);
            this.SerialReadTextbox.TabIndex = 4;
            // 
            // ReadSerialTimer
            // 
            this.ReadSerialTimer.Tick += new System.EventHandler(this.ReadSerialTimer_Tick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CommandsTab);
            this.TabControl.Controls.Add(this.WASDTab);
            this.TabControl.Controls.Add(this.XboxTab);
            this.TabControl.Controls.Add(this.AutomatedTab);
            this.TabControl.Controls.Add(this.settingsTab);
            this.TabControl.HotTrack = true;
            this.TabControl.ItemSize = new System.Drawing.Size(156, 20);
            this.TabControl.Location = new System.Drawing.Point(12, 53);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(785, 455);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 5;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // CommandsTab
            // 
            this.CommandsTab.Controls.Add(this.SendCommandBtn);
            this.CommandsTab.Controls.Add(this.CommandTextBox);
            this.CommandsTab.Location = new System.Drawing.Point(4, 24);
            this.CommandsTab.Name = "CommandsTab";
            this.CommandsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommandsTab.Size = new System.Drawing.Size(777, 427);
            this.CommandsTab.TabIndex = 0;
            this.CommandsTab.Text = "Commands";
            this.CommandsTab.UseVisualStyleBackColor = true;
            // 
            // SendCommandBtn
            // 
            this.SendCommandBtn.Location = new System.Drawing.Point(557, 48);
            this.SendCommandBtn.Name = "SendCommandBtn";
            this.SendCommandBtn.Size = new System.Drawing.Size(204, 29);
            this.SendCommandBtn.TabIndex = 1;
            this.SendCommandBtn.Text = "Send";
            this.SendCommandBtn.UseSelectable = true;
            this.SendCommandBtn.Click += new System.EventHandler(this.SendCommandBtn_Click);
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandTextBox.Location = new System.Drawing.Point(19, 48);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(532, 29);
            this.CommandTextBox.TabIndex = 0;
            // 
            // WASDTab
            // 
            this.WASDTab.Controls.Add(this.PressedKeyLabel);
            this.WASDTab.Controls.Add(this.KeyControlBtn);
            this.WASDTab.Controls.Add(this.SpeedLabel);
            this.WASDTab.Controls.Add(this.SpeedTrackBar);
            this.WASDTab.Location = new System.Drawing.Point(4, 24);
            this.WASDTab.Name = "WASDTab";
            this.WASDTab.Padding = new System.Windows.Forms.Padding(3);
            this.WASDTab.Size = new System.Drawing.Size(777, 427);
            this.WASDTab.TabIndex = 1;
            this.WASDTab.Text = "Key Control";
            this.WASDTab.UseVisualStyleBackColor = true;
            // 
            // PressedKeyLabel
            // 
            this.PressedKeyLabel.AutoSize = true;
            this.PressedKeyLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PressedKeyLabel.Location = new System.Drawing.Point(265, 188);
            this.PressedKeyLabel.Name = "PressedKeyLabel";
            this.PressedKeyLabel.Size = new System.Drawing.Size(99, 51);
            this.PressedKeyLabel.TabIndex = 3;
            this.PressedKeyLabel.Text = "Key: ";
            // 
            // KeyControlBtn
            // 
            this.KeyControlBtn.ActiveControl = null;
            this.KeyControlBtn.Location = new System.Drawing.Point(3, 3);
            this.KeyControlBtn.Name = "KeyControlBtn";
            this.KeyControlBtn.Size = new System.Drawing.Size(165, 45);
            this.KeyControlBtn.TabIndex = 2;
            this.KeyControlBtn.Text = "Enable Key Control";
            this.KeyControlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KeyControlBtn.UseSelectable = true;
            this.KeyControlBtn.Click += new System.EventHandler(this.KeyControlBtn_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(708, 5);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(60, 19);
            this.SpeedLabel.TabIndex = 1;
            this.SpeedLabel.Text = "Speed: 0";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.BackColor = System.Drawing.Color.White;
            this.SpeedTrackBar.LargeChange = 50;
            this.SpeedTrackBar.Location = new System.Drawing.Point(726, 25);
            this.SpeedTrackBar.Maximum = 400;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SpeedTrackBar.Size = new System.Drawing.Size(45, 396);
            this.SpeedTrackBar.SmallChange = 10;
            this.SpeedTrackBar.TabIndex = 0;
            this.SpeedTrackBar.TickFrequency = 10;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // XboxTab
            // 
            this.XboxTab.Controls.Add(this.ControllerLabel);
            this.XboxTab.Controls.Add(this.StickLabel);
            this.XboxTab.Controls.Add(this.LTLabel);
            this.XboxTab.Controls.Add(this.RTLabel);
            this.XboxTab.Controls.Add(this.XboxInputBtn);
            this.XboxTab.Location = new System.Drawing.Point(4, 24);
            this.XboxTab.Name = "XboxTab";
            this.XboxTab.Size = new System.Drawing.Size(777, 427);
            this.XboxTab.TabIndex = 2;
            this.XboxTab.Text = "Xbox Control";
            this.XboxTab.UseVisualStyleBackColor = true;
            // 
            // StickLabel
            // 
            this.StickLabel.AutoSize = true;
            this.StickLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StickLabel.Location = new System.Drawing.Point(230, 221);
            this.StickLabel.Name = "StickLabel";
            this.StickLabel.Size = new System.Drawing.Size(96, 25);
            this.StickLabel.TabIndex = 3;
            this.StickLabel.Text = "Stick Value:";
            // 
            // LTLabel
            // 
            this.LTLabel.AutoSize = true;
            this.LTLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LTLabel.Location = new System.Drawing.Point(230, 185);
            this.LTLabel.Name = "LTLabel";
            this.LTLabel.Size = new System.Drawing.Size(101, 25);
            this.LTLabel.TabIndex = 2;
            this.LTLabel.Text = "Left Trigger:";
            // 
            // RTLabel
            // 
            this.RTLabel.AutoSize = true;
            this.RTLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RTLabel.Location = new System.Drawing.Point(230, 150);
            this.RTLabel.Name = "RTLabel";
            this.RTLabel.Size = new System.Drawing.Size(113, 25);
            this.RTLabel.TabIndex = 1;
            this.RTLabel.Text = "Right Trigger:";
            // 
            // AutomatedTab
            // 
            this.AutomatedTab.Location = new System.Drawing.Point(4, 24);
            this.AutomatedTab.Name = "AutomatedTab";
            this.AutomatedTab.Size = new System.Drawing.Size(777, 427);
            this.AutomatedTab.TabIndex = 3;
            this.AutomatedTab.Text = "Automated";
            this.AutomatedTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.SaveSettingsTile);
            this.settingsTab.Controls.Add(this.RefreshPortsBtn);
            this.settingsTab.Controls.Add(this.PortComboBox);
            this.settingsTab.Controls.Add(this.PortLabel);
            this.settingsTab.Controls.Add(this.BaudLabel);
            this.settingsTab.Controls.Add(this.BaudTextBox);
            this.settingsTab.Location = new System.Drawing.Point(4, 24);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(777, 427);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsTile
            // 
            this.SaveSettingsTile.ActiveControl = null;
            this.SaveSettingsTile.Location = new System.Drawing.Point(212, 116);
            this.SaveSettingsTile.Name = "SaveSettingsTile";
            this.SaveSettingsTile.Size = new System.Drawing.Size(131, 50);
            this.SaveSettingsTile.TabIndex = 6;
            this.SaveSettingsTile.Text = "Save Settings";
            this.SaveSettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveSettingsTile.UseSelectable = true;
            this.SaveSettingsTile.Click += new System.EventHandler(this.SaveSettingsTile_Click);
            // 
            // RefreshPortsBtn
            // 
            this.RefreshPortsBtn.Location = new System.Drawing.Point(283, 20);
            this.RefreshPortsBtn.Name = "RefreshPortsBtn";
            this.RefreshPortsBtn.Size = new System.Drawing.Size(60, 29);
            this.RefreshPortsBtn.TabIndex = 9;
            this.RefreshPortsBtn.Text = "Refresh";
            this.RefreshPortsBtn.UseSelectable = true;
            this.RefreshPortsBtn.Click += new System.EventHandler(this.RefreshPortsBtn_Click);
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.ItemHeight = 23;
            this.PortComboBox.Location = new System.Drawing.Point(94, 20);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(173, 29);
            this.PortComboBox.TabIndex = 8;
            this.PortComboBox.UseSelectable = true;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(54, 24);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(37, 19);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port:";
            this.PortLabel.UseCustomBackColor = true;
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(19, 65);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(72, 19);
            this.BaudLabel.TabIndex = 7;
            this.BaudLabel.Text = "Baud Rate:";
            this.BaudLabel.UseCustomBackColor = true;
            // 
            // BaudTextBox
            // 
            this.BaudTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BaudTextBox.Location = new System.Drawing.Point(94, 64);
            this.BaudTextBox.Name = "BaudTextBox";
            this.BaudTextBox.Size = new System.Drawing.Size(173, 23);
            this.BaudTextBox.TabIndex = 5;
            // 
            // OpenPortBtn
            // 
            this.OpenPortBtn.ActiveControl = null;
            this.OpenPortBtn.Location = new System.Drawing.Point(980, 6);
            this.OpenPortBtn.Name = "OpenPortBtn";
            this.OpenPortBtn.Size = new System.Drawing.Size(110, 41);
            this.OpenPortBtn.TabIndex = 6;
            this.OpenPortBtn.Text = "Re-Open Port";
            this.OpenPortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenPortBtn.UseSelectable = true;
            this.OpenPortBtn.Click += new System.EventHandler(this.OpenPortBtn_Click);
            // 
            // ControllerLabel
            // 
            this.ControllerLabel.AutoSize = true;
            this.ControllerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ControllerLabel.Location = new System.Drawing.Point(230, 14);
            this.ControllerLabel.Name = "ControllerLabel";
            this.ControllerLabel.Size = new System.Drawing.Size(127, 25);
            this.ControllerLabel.TabIndex = 4;
            this.ControllerLabel.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 530);
            this.Controls.Add(this.OpenPortBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.SerialReadTextbox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zumo Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.TabControl.ResumeLayout(false);
            this.CommandsTab.ResumeLayout(false);
            this.CommandsTab.PerformLayout();
            this.WASDTab.ResumeLayout(false);
            this.WASDTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.XboxTab.ResumeLayout(false);
            this.XboxTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CommandsTab = new System.Windows.Forms.TabPage();
            this.WASDTab = new System.Windows.Forms.TabPage();
            this.XboxTab = new System.Windows.Forms.TabPage();
            this.AutomatedTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.RefreshPortsBtn = new MetroFramework.Controls.MetroButton();
            this.PortComboBox = new MetroFramework.Controls.MetroComboBox();
            this.PortLabel = new MetroFramework.Controls.MetroLabel();
            this.BaudLabel = new MetroFramework.Controls.MetroLabel();
            this.BaudTextBox = new System.Windows.Forms.TextBox();
            this.SaveSettingsTile = new MetroFramework.Controls.MetroTile();
            this.tabControl1.SuspendLayout();
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
            this.XboxInputBtn.Location = new System.Drawing.Point(13, 12);
            this.XboxInputBtn.Name = "XboxInputBtn";
            this.XboxInputBtn.Size = new System.Drawing.Size(139, 39);
            this.XboxInputBtn.TabIndex = 1;
            this.XboxInputBtn.Text = "Enable Xbox Input";
            this.XboxInputBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XboxInputBtn.UseSelectable = true;
            this.XboxInputBtn.Click += new System.EventHandler(this.XboxInputBtn_Click);
            // 
            // SerialReadTextbox
            // 
            this.SerialReadTextbox.Location = new System.Drawing.Point(615, 53);
            this.SerialReadTextbox.Multiline = true;
            this.SerialReadTextbox.Name = "SerialReadTextbox";
            this.SerialReadTextbox.Size = new System.Drawing.Size(284, 455);
            this.SerialReadTextbox.TabIndex = 4;
            // 
            // ReadSerialTimer
            // 
            this.ReadSerialTimer.Tick += new System.EventHandler(this.ReadSerialTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CommandsTab);
            this.tabControl1.Controls.Add(this.WASDTab);
            this.tabControl1.Controls.Add(this.XboxTab);
            this.tabControl1.Controls.Add(this.AutomatedTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 455);
            this.tabControl1.TabIndex = 5;
            // 
            // CommandsTab
            // 
            this.CommandsTab.Location = new System.Drawing.Point(4, 24);
            this.CommandsTab.Name = "CommandsTab";
            this.CommandsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommandsTab.Size = new System.Drawing.Size(570, 427);
            this.CommandsTab.TabIndex = 0;
            this.CommandsTab.Text = "Commands";
            this.CommandsTab.UseVisualStyleBackColor = true;
            // 
            // WASDTab
            // 
            this.WASDTab.Location = new System.Drawing.Point(4, 24);
            this.WASDTab.Name = "WASDTab";
            this.WASDTab.Padding = new System.Windows.Forms.Padding(3);
            this.WASDTab.Size = new System.Drawing.Size(570, 427);
            this.WASDTab.TabIndex = 1;
            this.WASDTab.Text = "Key Control";
            this.WASDTab.UseVisualStyleBackColor = true;
            // 
            // XboxTab
            // 
            this.XboxTab.Controls.Add(this.XboxInputBtn);
            this.XboxTab.Location = new System.Drawing.Point(4, 24);
            this.XboxTab.Name = "XboxTab";
            this.XboxTab.Size = new System.Drawing.Size(570, 427);
            this.XboxTab.TabIndex = 2;
            this.XboxTab.Text = "Xbox Control";
            this.XboxTab.UseVisualStyleBackColor = true;
            // 
            // AutomatedTab
            // 
            this.AutomatedTab.Location = new System.Drawing.Point(4, 24);
            this.AutomatedTab.Name = "AutomatedTab";
            this.AutomatedTab.Size = new System.Drawing.Size(570, 427);
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
            this.settingsTab.Size = new System.Drawing.Size(570, 427);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SerialReadTextbox);
            this.Name = "MainForm";
            this.Text = "Zumo Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.XboxTab.ResumeLayout(false);
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
        private TabControl tabControl1;
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
    }
}
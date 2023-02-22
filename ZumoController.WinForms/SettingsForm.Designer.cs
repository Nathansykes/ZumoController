namespace ZumoController.WinForms
{
    partial class SettingsForm
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
            this.SettingsFormStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SaveSettingsTile = new MetroFramework.Controls.MetroTile();
            this.BaudTextBox = new System.Windows.Forms.TextBox();
            this.BaudLabel = new MetroFramework.Controls.MetroLabel();
            this.PortComboBox = new MetroFramework.Controls.MetroComboBox();
            this.PortLabel = new MetroFramework.Controls.MetroLabel();
            this.RefreshPortsBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsFormStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsFormStyleManager
            // 
            this.SettingsFormStyleManager.Owner = null;
            this.SettingsFormStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.SettingsFormStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SaveSettingsTile
            // 
            this.SaveSettingsTile.ActiveControl = null;
            this.SaveSettingsTile.Location = new System.Drawing.Point(405, 336);
            this.SaveSettingsTile.Name = "SaveSettingsTile";
            this.SaveSettingsTile.Size = new System.Drawing.Size(166, 57);
            this.SaveSettingsTile.TabIndex = 0;
            this.SaveSettingsTile.Text = "Save";
            this.SaveSettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveSettingsTile.UseSelectable = true;
            this.SaveSettingsTile.Click += new System.EventHandler(this.SaveSettingsTile_Click);
            // 
            // BaudTextBox
            // 
            this.BaudTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BaudTextBox.Location = new System.Drawing.Point(110, 125);
            this.BaudTextBox.Name = "BaudTextBox";
            this.BaudTextBox.Size = new System.Drawing.Size(173, 23);
            this.BaudTextBox.TabIndex = 1;
            this.BaudTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaudTextBox_KeyPress);
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(32, 125);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(72, 19);
            this.BaudLabel.TabIndex = 2;
            this.BaudLabel.Text = "Baud Rate:";
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.ItemHeight = 23;
            this.PortComboBox.Location = new System.Drawing.Point(110, 81);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(173, 29);
            this.PortComboBox.TabIndex = 3;
            this.PortComboBox.UseSelectable = true;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(67, 81);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(37, 19);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port:";
            // 
            // RefreshPortsBtn
            // 
            this.RefreshPortsBtn.Location = new System.Drawing.Point(299, 81);
            this.RefreshPortsBtn.Name = "RefreshPortsBtn";
            this.RefreshPortsBtn.Size = new System.Drawing.Size(60, 29);
            this.RefreshPortsBtn.TabIndex = 4;
            this.RefreshPortsBtn.Text = "Refresh";
            this.RefreshPortsBtn.UseSelectable = true;
            this.RefreshPortsBtn.Click += new System.EventHandler(this.RefreshPortsBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 416);
            this.Controls.Add(this.RefreshPortsBtn);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.BaudLabel);
            this.Controls.Add(this.BaudTextBox);
            this.Controls.Add(this.SaveSettingsTile);
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsFormStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager SettingsFormStyleManager;
        private MetroFramework.Controls.MetroTile SaveSettingsTile;
        private TextBox BaudTextBox;
        private MetroFramework.Controls.MetroLabel BaudLabel;
        private MetroFramework.Controls.MetroComboBox PortComboBox;
        private MetroFramework.Controls.MetroLabel PortLabel;
        private MetroFramework.Controls.MetroButton RefreshPortsBtn;
    }
}
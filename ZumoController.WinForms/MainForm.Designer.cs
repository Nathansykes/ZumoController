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
            this.SettingsTile = new MetroFramework.Controls.MetroTile();
            this.XboxInputTimer = new System.Windows.Forms.Timer(this.components);
            this.XboxInputBtn = new MetroFramework.Controls.MetroTile();
            this.SerialReadTextbox = new System.Windows.Forms.RichTextBox();
            this.serialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingsTile
            // 
            this.SettingsTile.ActiveControl = null;
            this.SettingsTile.Location = new System.Drawing.Point(936, 12);
            this.SettingsTile.Name = "SettingsTile";
            this.SettingsTile.Size = new System.Drawing.Size(142, 55);
            this.SettingsTile.TabIndex = 0;
            this.SettingsTile.Text = "Settings";
            this.SettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsTile.UseSelectable = true;
            this.SettingsTile.Click += new System.EventHandler(this.SettingsTile_Click);
            // 
            // XboxInputTimer
            // 
            this.XboxInputTimer.Interval = 25;
            this.XboxInputTimer.Tick += new System.EventHandler(this.XboxInputTimer_Tick);
            // 
            // XboxInputBtn
            // 
            this.XboxInputBtn.ActiveControl = null;
            this.XboxInputBtn.Location = new System.Drawing.Point(936, 91);
            this.XboxInputBtn.Name = "XboxInputBtn";
            this.XboxInputBtn.Size = new System.Drawing.Size(142, 55);
            this.XboxInputBtn.TabIndex = 1;
            this.XboxInputBtn.Text = "Enable Xbox Input";
            this.XboxInputBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XboxInputBtn.UseSelectable = true;
            this.XboxInputBtn.Click += new System.EventHandler(this.XboxInputBtn_Click);
            // 
            // SerialReadTextbox
            // 
            this.SerialReadTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SerialReadTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialReadTextbox.Location = new System.Drawing.Point(624, 91);
            this.SerialReadTextbox.Name = "SerialReadTextbox";
            this.SerialReadTextbox.ReadOnly = true;
            this.SerialReadTextbox.Size = new System.Drawing.Size(262, 417);
            this.SerialReadTextbox.TabIndex = 2;
            this.SerialReadTextbox.Text = "";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(389, 109);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(38, 15);
            this.serialLabel.TabIndex = 3;
            this.serialLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 583);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.SerialReadTextbox);
            this.Controls.Add(this.XboxInputBtn);
            this.Controls.Add(this.SettingsTile);
            this.Name = "MainForm";
            this.Text = "Zumo Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile SettingsTile;
        private System.Windows.Forms.Timer XboxInputTimer;
        private MetroFramework.Controls.MetroTile XboxInputBtn;
        private RichTextBox SerialReadTextbox;
        private Label serialLabel;
    }
}
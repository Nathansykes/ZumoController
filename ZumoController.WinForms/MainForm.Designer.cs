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
            this.MainFormStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SettingsTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormStyleManager
            // 
            this.MainFormStyleManager.Owner = this;
            this.MainFormStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.MainFormStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SettingsTile
            // 
            this.SettingsTile.ActiveControl = null;
            this.SettingsTile.Location = new System.Drawing.Point(974, 27);
            this.SettingsTile.Name = "SettingsTile";
            this.SettingsTile.Size = new System.Drawing.Size(79, 40);
            this.SettingsTile.TabIndex = 0;
            this.SettingsTile.Text = "Settings";
            this.SettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsTile.UseSelectable = true;
            this.SettingsTile.Click += new System.EventHandler(this.SettingsTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 587);
            this.Controls.Add(this.SettingsTile);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Zumo Controller";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager MainFormStyleManager;
        private MetroFramework.Controls.MetroTile SettingsTile;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using System.IO;
using ZumoController.WinForms.Services;
using ZumoController.WinForms.Utils;


namespace ZumoController.WinForms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region setup
        private SerialCommunication? _serial;

        public SerialCommunication Serial
        {
            get
            {
                if (_serial == null)
                {
                    var settings = Settings.Load();
                    _serial = new SerialCommunication(settings.PortName, settings.BaudRate);
                }
                return _serial;
            }
        }
        #endregion  

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SettingsTile_Click(object sender, EventArgs e)
        {
            var settingsForm  = new SettingsForm();
            settingsForm.Show();
        }
    }
}
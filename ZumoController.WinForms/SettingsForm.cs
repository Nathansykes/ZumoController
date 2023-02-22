using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZumoController.WinForms.Services;

namespace ZumoController.WinForms
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        private Settings? _settings;

        public Settings Settings
        {
            get
            {
                _settings ??= Settings.Load();
                return _settings;
            }
        }
        public SettingsForm()
        {
            InitializeComponent();
            GetPorts();
            PortComboBox.SelectedText = Settings.PortName;
            BaudTextBox.Text = Settings.BaudRate.ToString();
        }

        private void GetPorts()
        {
            var ports = SerialCommunication.GetAvailablePorts();
            if (ports?.Any() ?? false)
            {
                ports = new List<string> { "No Ports Available" };
            }
            PortComboBox.DataSource = ports;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveSettingsTile_Click(object sender, EventArgs e)
        {
            Settings.PortName= PortComboBox.SelectedText;
            Settings.BaudRate = int.Parse(BaudTextBox.Text);
            Settings.Save();
            Close();
        }

        private void RefreshPortsBtn_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void BaudTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

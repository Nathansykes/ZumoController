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
using SharpDX.XInput;
using System.IO.Ports;

namespace ZumoController.WinForms
{
    public partial class MainForm : Form
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


        private Controller Controller;
        public MainForm()
        {
            InitializeComponent();
            Controller = new Controller(UserIndex.One);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Serial.Port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
        }

        private void SettingsTile_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private const short StickDeadZone = 4000;
        private void XboxInputTimer_Tick(object sender, EventArgs e)
        {
            if (Controller.IsConnected)
            {
                var state = Controller.GetState();
                if (state.PacketNumber != 0)
                {
                    var a = state.Gamepad.LeftThumbX;
                    var b = state.Gamepad.RightThumbX;
                    var stickX = (long)Math.Abs((long)a) > (long)Math.Abs((long)b) ? a : b;
                    stickX = stickX > StickDeadZone || stickX < -StickDeadZone ? stickX : (short)0;
                    Serial.HandleXboxInput(stickX, state.Gamepad.RightTrigger, state.Gamepad.LeftTrigger);
                }
            }
            Thread.Sleep(10);
            var str = Serial.Port.ReadLine();
            var tstr = Environment.NewLine + DateTime.Now.ToString("hh:mm:ss:ff") + " - " + str;
            Debug.WriteLine(tstr);
            SerialReadTextbox.Text = tstr + SerialReadTextbox.Text;
            if (SerialReadTextbox.Text.Length >= 1000000)
                SerialReadTextbox.Text.Remove(5000);
        }

        //void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    var port = (SerialPort)sender;
        //    if (port.IsOpen)
        //    {
        //        var str = port.ReadLine();
        //        if (string.IsNullOrWhiteSpace(str)) return;
        //        var tstr = "";
        //        if(serialRead == null || (!serialRead.Any()))
        //            serialRead = new List<string>();
        //        serialRead.Add(str);
        //    }
        //}
        //private List<string> serialRead;

        private void ReadSerialTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void XboxInputBtn_Click(object sender, EventArgs e)
        {
            if (XboxInputTimer.Enabled)
            {
                XboxInputTimer.Stop();
                XboxInputBtn.Text = "Enable Xbox Input";
            }
            else
            {
                XboxInputTimer.Start();
                XboxInputBtn.Text = "Disable Xbox Input";
            }

        }
    }
}
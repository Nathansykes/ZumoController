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
        public void SetPortDefaults()
        {
            _port.NewLine = "\n";
            _port.Handshake = Handshake.None;
            _port.DtrEnable = true;
            _port.WriteBufferSize = 1024;
        }
        private SerialPort _port;
        public SerialPort Port { 
            get => _port; 
            set
            {
                _port = value;
                SetPortDefaults();
            }
        }

        private readonly Controller Controller;
        public MainForm()
        {
            InitializeComponent();
            Controller = new Controller(UserIndex.One);
            var settings = Settings.Load();
            if (!settings.IsValid())
                settings = new Settings();
            Port = new SerialPort(settings.PortName, settings.BaudRate);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
            ReadSerialTimer.Start();
            var settings = Settings.Load();
            GetPorts();
            PortComboBox.SelectedItem = settings.PortName;
            BaudTextBox.Text = settings.BaudRate.ToString();
        }

        private const short StickDeadZone = 4000;
        private byte timerLoopCount = 0;
        private void XboxInputTimer_Tick(object sender, EventArgs e)
        {
            //timerLoopCount++;
            if (Controller.IsConnected)
            {
                var state = Controller.GetState();
                if (state.PacketNumber != 0)
                {
                    var a = state.Gamepad.LeftThumbX;
                    var b = state.Gamepad.RightThumbX;
                    var stickX = (long)Math.Abs((long)a) > (long)Math.Abs((long)b) ? a : b;
                    stickX = stickX > StickDeadZone || stickX < -StickDeadZone ? stickX : (short)0;
                    HandleXboxInput(stickX, state.Gamepad.RightTrigger, state.Gamepad.LeftTrigger);
                }
            }

            //if (timerLoopCount < 4)
            //    return;
            //timerLoopCount = 0;
            //Thread.Sleep(10);
            //var str = Port.ReadLine();
            //if (!string.IsNullOrWhiteSpace(str))
            //{
            //    var tstr = Environment.NewLine + DateTime.Now.ToString("hh:mm:ss:ff") + " - " + str;
            //    Debug.WriteLine(tstr);
            //    SerialReadTextbox.Text = tstr + SerialReadTextbox.Text;
            //    if (SerialReadTextbox.Text.Length >= 1000000)
            //        SerialReadTextbox.Text.Remove(5000);
            //}
        }

        public void WriteMotorSpeeeds(int leftSpeed, int rightSpeed)
        {
            if (Port.IsOpen)
            {
                Port.WriteLine($"{leftSpeed},{rightSpeed}");
            }
        }

        public void WriteWASDCommand(char direction, int speed)
        {
            if (Port.IsOpen)
            {
                Port.WriteLine($"{direction}{speed}");
            }
        }


        public void HandleXboxInput(short turnValue, byte forwardValue, byte reverseValue)
        {
            int turnAmount = ((decimal)turnValue).Remap(short.MinValue, short.MaxValue, -100, 100);
            var normal = forwardValue - reverseValue;
            int speed = ((decimal)(normal)).Remap(-byte.MaxValue, byte.MaxValue, -300, 300);

            int speedDiff = (speed * turnAmount) / 100;

            int leftSpeed = speed + speedDiff;
            int rightSpeed = speed - speedDiff;


            WriteMotorSpeeeds(leftSpeed, rightSpeed);
        }

        void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            if (port.IsOpen)
            {
                var str = port.ReadLine();
                if (string.IsNullOrWhiteSpace(str)) return;
                var tstr = Environment.NewLine + DateTime.Now.ToString("hh:mm:ss:ff") + " - " + str;
                serialRead += tstr;
            }
            else
            {
                serialRead = "Port not available";
            }
        }
        private string serialRead = "";

        private void ReadSerialTimer_Tick(object sender, EventArgs e)
        {
            SerialReadTextbox.Text = serialRead;
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

        private void ModeTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private const string NoPortsText = "No Ports Available";

        private void GetPorts()
        {
            PortComboBox.Items.Clear();
            var ports = SerialPort.GetPortNames();
            if (ports == null || ports.Length == 0)
            {
                ports = new string[] { NoPortsText };
            }
            PortComboBox.Items.AddRange(ports);
        }

        private void SaveSettingsTile_Click(object sender, EventArgs e)
        {

            if (Port.IsOpen)
            {
                Port.Close();
            }
            var settings = Settings.Load();
            if ((!string.IsNullOrWhiteSpace(PortComboBox.SelectedItem.ToString())) && PortComboBox.SelectedItem.ToString() != NoPortsText)
                settings.PortName = PortComboBox.SelectedItem?.ToString() ?? "";

            settings.BaudRate = int.Parse(BaudTextBox.Text);
            if(!settings.IsValid())
                settings = new Settings();
            settings.Save();
            Port = new SerialPort(settings.PortName, settings.BaudRate);
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
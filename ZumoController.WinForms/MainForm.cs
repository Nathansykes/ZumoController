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

        #region Setup and Startup
        //set the defaults forn the port to communicate with zumo
        public void SetPortDefaults()
        {
            _port.NewLine = "\n";
            _port.Handshake = Handshake.None;
            _port.DtrEnable = true;
            _port.WriteBufferSize = 1024;
        }
        private SerialPort _port;
        public SerialPort Port
        {
            get => _port;
            set
            {
                _port = value;
                SetPortDefaults();//everytime the Port is changed, we reset the defaults
            }
        }


        private readonly Controller Controller;
        public MainForm()
        {
            InitializeComponent();
            Controller = new Controller(UserIndex.One);
            var settings = Settings.Load();//gets the settings from storage
            if (!settings.IsValid())
                settings = new Settings();//recreates them with defaults if not valid
            Port = new SerialPort(settings.PortName, settings.BaudRate);//instantiate the port from the settings
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);//add the event handler for serial reading

            //if the port fails to open, let the user know
            try
            {
                Port.Open();
            }
            catch (Exception ex)
            {
                serialRead = ex.ToString();
            }
            ReadSerialTimer.Start();//start the timer to read from port
            var settings = Settings.Load();
            GetPorts();
            PortComboBox.SelectedItem = settings.PortName;//set the selected values on the settings page
            BaudTextBox.Text = settings.BaudRate.ToString();
        }

        #endregion

        #region Port Write

        //directly writes the left and right motor speeds
        public void WriteMotorSpeeeds(int leftSpeed, int rightSpeed)
        {
            if (Port.IsOpen)
            {
                Port.WriteLine($"{leftSpeed},{rightSpeed}");
            }
        }
		//writes the direction and speed to the port
        public void WriteWASDCommand(char direction, int speed)
        {
            Debug.WriteLine($"{direction}{speed}");
            if (Port.IsOpen)
            {
                Port.WriteLine($"{direction}{speed}");
            }
        }
        private void SendCommandBtn_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Write(CommandTextBox.Text);
            }
        }
        #endregion

        #region Reading Serial
        void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            if (!port.IsOpen)
                port.Open();

            var str = port.ReadLine();
            if (string.IsNullOrWhiteSpace(str)) return;
            var tstr = Environment.NewLine + DateTime.Now.ToString("hh:mm:ss:ff") + " - " + str; //prepend received with the current time
            serialRead = tstr + serialRead;//prepend the new line
            if (serialRead.Length > 3000)//if the read data gets too long, trim it to not increase memeory usage
                serialRead = serialRead.Substring(0, 2000);
        }

        private string serialRead = "";

        private void ReadSerialTimer_Tick(object sender, EventArgs e)
        {
            //ReadFromPort(Port);
            SerialReadTextbox.Text = serialRead;
        }
        #endregion

        #region Xbox control

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

        private const short StickDeadZone = 4000;//stick never fully returns to zero
        private int LastPacket = 0;
        private void XboxInputTimer_Tick(object sender, EventArgs e)
        {
            if (Controller.IsConnected)
            {
                ControllerLabel.Text = "Connected";
                var state = Controller.GetState();
                if (state.PacketNumber != LastPacket)//only get new packet data
                {
                    LastPacket = state.PacketNumber;
                    //get the values from the controller
                    var a = state.Gamepad.LeftThumbX;
                    var b = state.Gamepad.RightThumbX;
                    var stickX = (long)Math.Abs((long)a) > (long)Math.Abs((long)b) ? a : b;//get the value of the stick closest to the middle (0)
                    stickX = stickX > StickDeadZone || stickX < -StickDeadZone ? stickX : (short)0; //if its less than the deadzone get 0

                    //map those values to the ranges we need
                    int turnAmount = ((decimal)stickX).Remap(short.MinValue, short.MaxValue, -200, 200);
                    var normal = state.Gamepad.RightTrigger - state.Gamepad.LeftTrigger;//get the difference between the values
                    int speed = ((decimal)(normal)).Remap(-byte.MaxValue, byte.MaxValue, -200, 200);

                    //calculate the amount to adjust the turn by
                    int speedDiff = (speed * turnAmount) / 100;

                    //calculate left and right speeds
                    int leftSpeed = speed + speedDiff;
                    int rightSpeed = speed - speedDiff;

                    //write to the robot
                    WriteMotorSpeeeds(leftSpeed, rightSpeed);

                    //get the values to display in GUI
                    var RTval = ((decimal)state.Gamepad.RightTrigger).Remap(byte.MinValue, byte.MaxValue, 0, 300);
                    var LTval = ((decimal)state.Gamepad.LeftTrigger).Remap(byte.MinValue, byte.MaxValue, 0, 300);

                    //update the view
                    RTLabel.Text = $"Right Trigger: {RTval}";
                    LTLabel.Text = $"Right Trigger: {LTval}";
                    StickLabel.Text = $"Stick Value: {turnAmount}";
                }
            }
            else
            {
                ControllerLabel.Text = "Not Connected";
            }
            GC.Collect();//collect any unmanaged memory usage to prevent leaks
        }

        #endregion

        #region Settings Management

        private const string NoPortsText = "No Ports Available";

        //gets the available prorts and adds them to the combo box
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
                Port.Close();//close the port if its open
            }
            var settings = new Settings();//create a new settings model with the defaults
            if ((!string.IsNullOrWhiteSpace(PortComboBox.SelectedItem.ToString())) && PortComboBox.SelectedItem.ToString() != NoPortsText)//if a valid port is selected
                settings.PortName = PortComboBox.SelectedItem?.ToString() ?? "";

            settings.BaudRate = int.Parse(BaudTextBox.Text);
            if (!settings.IsValid())//checks the settings on the model are valid
                settings = new Settings();
            settings.Save();//save the settings
            Port = new SerialPort(settings.PortName, settings.BaudRate);//reinstantiate the port
        }

        private void RefreshPortsBtn_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void BaudTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//only allow number
            {
                e.Handled = true;
            }
        }

        private void OpenPortBtn_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
                Port.Close();
            try
            {

                Port.Open();
            }
            catch (Exception ex)
            {
                serialRead = ex.ToString();
            }
        }
        #endregion

        #region Key Control
        private void KeyControlBtn_Click(object sender, EventArgs e)
        {
            if (keyControlEnabled)//disabling
            {
                keyControlEnabled = false;
                KeyControlBtn.Text = "Enable Key Control";
                WriteWASDCommand('x', 0);
            }
            else
            {
                keyControlEnabled = true;
                KeyControlBtn.Text = "Disable Key Control";
            }
        }

        private bool keyControlEnabled = false;
        private readonly List<Keys> ValidKeys = new List<Keys> { Keys.W, Keys.A, Keys.S, Keys.D, Keys.X };
        private bool keyDown = false;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyDown)
            {
                keyDown = true;
                if (keyControlEnabled)
                {
                    if (!ValidKeys.Contains(e.KeyCode))
                        return;
                    //get the selected key to lower as a char
                    char key = e.KeyCode.ToString().ToLower().ToCharArray()[0];
                    if (e.Shift)
                    {
                        key = char.ToUpper(key);//if shift was held then send it in CAPS
                    }
                    WriteWASDCommand(key, SpeedTrackBar.Value);
                    PressedKeyLabel.Text = $"Key: {key}";//set the label to what key was press
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            keyDown = false;
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            SpeedLabel.Text = $"Speed: {SpeedTrackBar.Value}";
        }

        #endregion

        #region Mode Selection

        private const string Mode_ModeSelect = "m";
        private const string Mode_SetMotors = "p";
        private const string Mode_WASD = "o";
        private const string Mode_Automated = "i";
        private const string Mode_SemiAuto = "u";

        enum Modes
        {
            None = 0,
            WASD = 1,
            Xbox = 2,
            Auto = 3,
            SemiAuto = 4,
        }
        private Modes _selectedMode = Modes.None;
        private Modes SelectedMode
        {
            get { return _selectedMode; }
            set
            {
                _selectedMode = value;
                UpdateMode(_selectedMode);//change the mode every time the variable is updated
            }
        }

        private void UpdateMode(Modes mode)
        {
            Debug.WriteLine($"Mode changed to: {mode}");
            if (Port.IsOpen)
            {
                Port.Write(Mode_ModeSelect + "\n");//go into mode select
                Thread.Sleep(25);//wait before sending another command
                switch (mode)
                {
                    case Modes.Xbox:
                        Port.Write(Mode_SetMotors + "\n");
                        break;
                    case Modes.WASD:
                        Port.Write(Mode_WASD + "\n");
                        break;
                    case Modes.Auto:
                        Port.Write(Mode_Automated + "\n");
                        break;
                    case Modes.SemiAuto:
                        Port.Write(Mode_SemiAuto + "\n");
                        break;
                    case Modes.None:
                        Port.Write(Mode_ModeSelect + "\n");
                        break;
                    default:
                        break;
                }
            }
        }

        //every time a mode toggle is clicked, if it is checked set it to the mode, if not set it to mode select
        //always resets all toggles to false if one is clicked
        private void WASDModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            SelectedMode = WASDModeToggle.Checked ? Modes.WASD : Modes.None;
            XboxControlToggle.Checked = false;
            FullAutoModeToggle.Checked = false;
            SemiAutoModeToggle.Checked = false;
            
        }

        private void XboxControlToggle_CheckedChanged(object sender, EventArgs e)
        {
            SelectedMode = XboxControlToggle.Checked ? Modes.Xbox : Modes.None;
            WASDModeToggle.Checked = false;
            FullAutoModeToggle.Checked = false;
            SemiAutoModeToggle.Checked = false;
        }

        private void FullAutoModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            SelectedMode = FullAutoModeToggle.Checked ? Modes.Auto : Modes.None;
            WASDModeToggle.Checked = false;
            XboxControlToggle.Checked = false;
            SemiAutoModeToggle.Checked = false;
            
        }

        private void SemiAutoModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            SelectedMode = SemiAutoModeToggle.Checked ? Modes.SemiAuto : Modes.None;
            WASDModeToggle.Checked = false;
            XboxControlToggle.Checked = false;
            FullAutoModeToggle.Checked = false;
        }
        #endregion
    }
}
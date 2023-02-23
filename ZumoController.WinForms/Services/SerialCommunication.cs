using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;
using ZumoController.WinForms.Utils;

namespace ZumoController.WinForms.Services
{
    public class SerialCommunication
    {
        #region Setup

        public SerialPort Port;

        public string PortName { get; private set; }
        public int BaudRate { get; private set; }

        public SerialCommunication(string portName, int baudRate)
        {
            if(string.IsNullOrWhiteSpace(portName))
                portName = "COM4";
            Port = new SerialPort(portName, baudRate);
            PortName = portName;
            BaudRate = baudRate;
            SetDefaults();
            CheckOpenPort();
        }
        public SerialCommunication(SerialPort port)
        {
            Port = port;
            PortName = Port.PortName;
            BaudRate = Port.BaudRate;
            CheckOpenPort();
        }

        public void SetDefaults()
        {
            Port.NewLine = "\n";
            Port.Handshake = Handshake.None;
            Port.DtrEnable = true;
            Port.WriteBufferSize = 1024;
        }

        #endregion

        #region UtilMethods

        public bool CheckOpenPort()
        {
            if (!Port.IsOpen)
            {
                try
                {
                    Port.Open();
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    return false;
                }
            }
            return Port.IsOpen;
        }

        public static string[] GetAvailablePorts() => SerialPort.GetPortNames();
        

        #endregion

        #region Methods
        public void Write(string s)
        {
            if (CheckOpenPort())
            {
                Port.Write(s);
            }
        }

        public string? Read()
        {
            string? ret = "";
            if (CheckOpenPort())
                ret = Port.ReadExisting();
            return ret;
        }

        public void WriteMotorSpeeeds(int leftSpeed, int rightSpeed)
        {
            if (CheckOpenPort())
            {
                Port.WriteLine($"{leftSpeed},{rightSpeed}");
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

        #endregion
    }
}

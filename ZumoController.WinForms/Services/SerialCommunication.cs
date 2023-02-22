using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;

namespace ZumoController.WinForms.Services
{
    public class SerialCommunication
    {
        #region Setup

        internal SerialPort Port;

        public string PortName { get; private set; }
        public int BaudRate { get; private set; }

        public SerialCommunication(string portName, int baudRate)
        {
            Port = new SerialPort(portName, baudRate);
            PortName = portName;
            BaudRate = baudRate;
            CheckOpenPort();
        }
        public SerialCommunication(SerialPort port)
        {
            Port = port;
            PortName = Port.PortName;
            BaudRate = Port.BaudRate;
            CheckOpenPort();
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

        public static List<string> GetAvailablePorts()
        {
            return SerialPort.GetPortNames().ToList();
        }

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

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoken_Gloves_Project
{
    public static class clsSharedSerialPort
    {
      
            private static SerialPort _serialPort;

            public static void InitializeSerialPort(string portName, int baudRate)
            {
                _serialPort = new SerialPort(portName, baudRate);
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

            }
            catch
            {
                MessageBox.Show("Can't Open Port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

            public static SerialPort GetSerialPortInstance()
            {
                return _serialPort;
            }

    }
}

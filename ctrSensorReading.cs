using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using SpokenGlovesBussiness1;

namespace Spoken_Gloves_Project
{
    public partial class ctrSensorReading : UserControl
    {
        SerialPort serialPort;
        private string _TextBoxReadings;
        private List<string> _Readings = new List<string>();
        public ctrSensorReading()
        {
            InitializeComponent();
            serialPort = clsSharedSerialPort.GetSerialPortInstance();
        }
        public List<string> Readings
        {
            get { return _Readings; }
        }
        public string TextBoxReadings
        {
            get { return _TextBoxReadings; }
        }
        private void ctrSensorReading_Load(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
             
            }
            catch
            { 
                MessageBox.Show("Can't Open Port.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
      
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        string DataLine = "";
        private string _FingersState(string DataLine)
        {
            string FingerState = "";
            string[] Fingers = DataLine.Split('#');
            if (Convert.ToInt32(Fingers[0]) > 472)
            {
                FingerState += "Finger1Down#";
            }
            else
            {
                FingerState += "Finger1Up#";
            }
  
            if (Convert.ToInt32(Fingers[1]) > 410)
            {
                FingerState += "Finger2Down#";
            }
            else
            {
                FingerState += "Finger2Up#";
            }

            if (Convert.ToInt32(Fingers[2]) > 430)
            {
                FingerState += "Finger3Down#";
            }
            else
            {
                FingerState += "Finger3Up#";
            }
       
            if (Convert.ToInt32(Fingers[3]) > 410)
            {
                FingerState += "Finger4Down#";
            }
            else
            {
                FingerState += "Finger4Up#";
            }

            if (Convert.ToInt32(Fingers[4]) > 465)
            {
                FingerState += "Finger5Down\n";
            }
            else
            {
                FingerState += "Finger5Up\n";
            }
            return FingerState;
        }
        public string GetLastLine(string input)
        {
            string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length > 0)
            {
                return lines[lines.Length - 1];
            }

            return string.Empty; // Return an empty string if the input is empty or contains no lines
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort.ReadTimeout = 2000;
            DataLine = serialPort.ReadExisting();
            string LastLine =  GetLastLine(DataLine);
            textBoxReadings.Text += LastLine+"\n";
            _TextBoxReadings = textBoxReadings.Text;

            _Readings.Add(LastLine);
        }
        public void Start()
        {
            timer1.Start();
        }
        public void Stop()
        {
            timer1.Stop();
        }
        public string CurrentReadings()
        {
            return DataLine;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxReadings.Text = string.Empty;
        }
    }
}

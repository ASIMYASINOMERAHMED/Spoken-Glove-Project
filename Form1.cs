using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using SpokenGlovesBussiness1;
using System.IO.Ports;
using System.Threading;

namespace Spoken_Gloves_Project
{
    public partial class Form1 : Form
    {
        private DataTable _dtAllSignsData;
        private string _CurrentReadings;
        private string[] _GetStrings;
        private clsSignInfo _SignInfo;
        SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            clsSharedSerialPort.InitializeSerialPort("COM4", 9600);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddSign_Click(object sender, EventArgs e)
        {
            frmAddSign frmAddSign = new frmAddSign();
            frmAddSign.ShowDialog();
            _dtAllSignsData = clsSignData.GetAllSignsData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateSign frmUpdateSign = new frmUpdateSign();
            frmUpdateSign.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmRemoveSign frmRemoveSign = new frmRemoveSign();
            frmRemoveSign.ShowDialog();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SpeakAsync(lbText1.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("Serial Port Not Opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Task.Run(()=> timer1.Start());
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dtAllSignsData = clsSignData.GetAllSignsData();
           serialPort = clsSharedSerialPort.GetSerialPortInstance();
     
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Sensors stop reading.", "Stopping", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void lbText_TextChanged(object sender, EventArgs e)
        {
            btnSpeak1.PerformClick();
            picBoxSign.ImageLocation = _SignInfo.ImagePath;
        }

        private void _CheckEqualityOfReadings(string CurrentReadings,DataTable dt)
        {
            string[] GetStrings = CurrentReadings.Split('#');
            //int Flex1 = Convert.ToInt32(GetStrings[0]);
            //int Flex2 = Convert.ToInt32(GetStrings[1]);
            //int Flex3 = Convert.ToInt32(GetStrings[2]);
            //int Flex4 = Convert.ToInt32(GetStrings[3]);
            //int Flex5 = Convert.ToInt32(GetStrings[4]);

            //Parallel.ForEach(dt.AsEnumerable(), drow =>
            //{
            //    string[] Flex1MaxMin = drow[1].ToString().Split('#');
            //    string[] Flex2MaxMin = drow[2].ToString().Split('#');
            //    string[] Flex3MaxMin = drow[3].ToString().Split('#');
            //    string[] Flex4MaxMin = drow[4].ToString().Split('#');
            //    string[] Flex5MaxMin = drow[5].ToString().Split('#');
            //    if (Enumerable.Range(Convert.ToInt32(Flex1MaxMin.Min()), Convert.ToInt32(Flex1MaxMin.Max())).Contains(Flex1) && Enumerable.Range(Convert.ToInt32(Flex2MaxMin.Min()), Convert.ToInt32(Flex2MaxMin.Max())).Contains(Flex2) &&
            //            Enumerable.Range(Convert.ToInt32(Flex3MaxMin.Min()), Convert.ToInt32(Flex3MaxMin.Max())).Contains(Flex3) && Enumerable.Range(Convert.ToInt32(Flex4MaxMin.Min()), Convert.ToInt32(Flex4MaxMin.Max())).Contains(Flex4) && Enumerable.Range(Convert.ToInt32(Flex5MaxMin.Min()), Convert.ToInt32(Flex5MaxMin.Max())).Contains(Flex5))
            //    {
            //        _SignInfo = clsSignInfo.Find(Convert.ToInt32(drow[7]));


            //    }
            //});
            //Parallel.ForEach(dt.AsEnumerable(), drow =>
            //{
            //    if (GetStrings[0] == drow[1].ToString()&& GetStrings[1] == drow[2].ToString()&& GetStrings[2] == drow[3].ToString()
            //    && GetStrings[3] == drow[4].ToString()&& GetStrings[4] == drow[5].ToString())
            //    {
            //        _SignInfo = clsSignInfo.Find(Convert.ToInt32(drow[7]));
            //    }
            //});
            foreach(DataRow row  in dt.Rows)
            {
           
                if ((GetStrings[0] == row[1].ToString()) && (GetStrings[1] == row[2].ToString()) &&( GetStrings[2] == row[3].ToString())
              && (GetStrings[3] == row[4].ToString()) && ( GetStrings[4] == row[5].ToString().Trim()))
                {
                    _SignInfo = clsSignInfo.Find(Convert.ToInt32(row[7]));
                }
            }
            if (_SignInfo != null)
            {
                lbText1.Text = _SignInfo.Text;
                picboxSign1.ImageLocation = _SignInfo.ImagePath;
            }
            _SignInfo = null;

        }
        private short GetRandomToken()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 5);
            return (short)randomNumber;
        }
        private bool GetRandombool()
        {
            Random rand = new Random();
            bool randomBool = rand.NextDouble() >= 0.5;
            return randomBool;
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
         
           _CurrentReadings = serialPort.ReadExisting();
            string LastLine =  GetLastLine(_CurrentReadings);
         
            _CheckEqualityOfReadings(LastLine, _dtAllSignsData);
          
        }
    }
}

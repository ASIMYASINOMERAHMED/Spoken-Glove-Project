using SpokenGlovesBussiness1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoken_Gloves_Project
{
    public partial class frmReadings : Form
    {
        private clsSignData _SignData;
        private int _SignInfoID;
        public frmReadings(int signInfoID)
        {
            InitializeComponent();
            _SignInfoID = signInfoID;
        }

        private bool SaveReadings(List<string> Readings)
        {
            clsSignData _SignData = new clsSignData();
            //string FirstReading = Readings[0];
            //string[] S1 = FirstReading.Split('#');
            string LastReading = Readings[Readings.Count - 1];
            string[] S2 = LastReading.Split('#');
            _SignData.Flex1Read = S2[0]; //$"{Convert.ToInt32(S1[0])}#{Convert.ToInt32(S2[0])}";
            _SignData.Flex2Read = S2[1]; //$"{Convert.ToInt32(S1[1])}#{Convert.ToInt32(S2[1])}";
            _SignData.Flex3Read = S2[2]; //$"{Convert.ToInt32(S1[2])}#{Convert.ToInt32(S2[2])}";
            _SignData.Flex4Read = S2[3]; //$"{Convert.ToInt32(S1[3])}#{Convert.ToInt32(S2[3])}";
            _SignData.Flex5Read = S2[4]; //$"{Convert.ToInt32(S1[4])}#{Convert.ToInt32(S2[4])}";
            _SignData.Angle = 0;
            _SignData.SignInfoID = _SignInfoID;
            if (_SignData.Save())
                return true;
            else
            {
                MessageBox.Show("Error Saving Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //foreach (string DataLine in Readings)
            //{
            //    if (!string.IsNullOrEmpty(DataLine))
            //    {
            //        string[] S1 = DataLine.Split('#');
            //        _SignData.Flex1Read = Convert.ToInt32(S1[0]);
            //        _SignData.Flex2Read = Convert.ToInt32(S1[1]);
            //        _SignData.Flex3Read = Convert.ToInt32(S1[2]);
            //        _SignData.Flex4Read = Convert.ToInt32(S1[3]);
            //        _SignData.Flex5Read = Convert.ToInt32(S1[4]);
            //        _SignData.Angle = 0;
            //        _SignData.SignInfoID = _SignInfoID;
            //        if(_SignData.Save())
            //        {
            //            _SignData = new clsSignData();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error Saving Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return false;
            //        }
            //    }

            //}


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(clsSignData.DeleteAllSignData(_SignInfoID))
            {
                if (string.IsNullOrEmpty(ctrSensorReading1.TextBoxReadings))
                {
                    MessageBox.Show("Make Sure Sensors are reading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SaveReadings(ctrSensorReading1.Readings))
                {
                    MessageBox.Show("Data Saved Succssfully.", "Succss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("An Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}

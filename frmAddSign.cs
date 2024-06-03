using SpokenGlovesBussiness1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoken_Gloves_Project
{
    public partial class frmAddSign : Form
    {
       
        private clsSignInfo _SignInfo;
        private int _SignInfoID;

        public frmAddSign()
        {
            InitializeComponent();
     
            _SignInfo = new clsSignInfo();

        }

      

        private void txtSignText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSignText.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSignText, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSignText, null);
            }
        }

        private void txtImageLocation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtImageLocation.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtImageLocation, "Please Select an Image!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtImageLocation, null);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                txtImageLocation.Text = selectedFilePath;
            }
        }

      
        private void frmAddSign_Load(object sender, EventArgs e)
        {
            tbSensorRead.Enabled = false;
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
       
        private void btnNext_Click_1(object sender, EventArgs e)
        { 
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if(clsSignInfo.IsSignExist(txtSignText.Text.Trim()))
            {
                MessageBox.Show("Sign Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SignInfo.Text = txtSignText.Text.Trim();
            _SignInfo.ImagePath = txtImageLocation.Text.Trim();
            if (_SignInfo.Save())
            {
                _SignInfoID = _SignInfo.SignInfoID;
                tabControl1.SelectTab("tbSensorRead");
                tbSensorRead.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error Saving Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAddSign_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrSensorReading1.TextBoxReadings))
            {
                MessageBox.Show("Make Sure Sensors are reading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SaveReadings(ctrSensorReading1.Readings))
            {
                MessageBox.Show("Sign Saved Succssfully.", "Succss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                this.Close();
        }
    }
}

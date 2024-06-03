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
    public partial class frmEditSignInfo : Form
    {
        private int _SignInfoID;
        private clsSignInfo _SignInfo;
        public frmEditSignInfo(int SignInfoID)
        {
            InitializeComponent();
            _SignInfoID = SignInfoID;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _SignInfo.Text = txtSignText.Text;
            _SignInfo.ImagePath = txtImageLocation.Text;
            if(_SignInfo.Save())
            {
                MessageBox.Show("Data Saved Succssfully.","Succss",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable to save Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmEditSignInfo_Load(object sender, EventArgs e)
        {
            _SignInfo = clsSignInfo.Find(_SignInfoID);
            if( _SignInfo == null )
            {
                MessageBox.Show("Sign has been deleted.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            txtSignText.Text = _SignInfo.Text;
            txtImageLocation.Text = _SignInfo.ImagePath;
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
    }
}

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
    public partial class frmRemoveSign : Form
    {
        private DataTable _dtSigns;
        public frmRemoveSign()
        {
            InitializeComponent();
        }

        private void frmRemoveSign_Load(object sender, EventArgs e)
        {
            _dtSigns = clsSignInfo.GetAllSigns();
            if(_dtSigns.Rows.Count == 0 )
            {
                MessageBox.Show("No Signs Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                dgvSigns.DataSource = _dtSigns;
            }
            
        }

        private void dgvSigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvSigns.CurrentRow;
            int SignInfoID = Convert.ToInt32(currentRow.Cells[1].Value?.ToString());
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && currentRow != null)
            {
                if (dgvSigns.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dgvSigns.Rows.Count)
                {
                    if (MessageBox.Show("Confirm delete.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clsSignInfo.Delete(SignInfoID))
                        {
                            MessageBox.Show("Deleted succssfully.", "succss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmRemoveSign_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("unable to delete sign.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

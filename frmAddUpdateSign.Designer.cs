namespace Spoken_Gloves_Project
{
    partial class frmAddSign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSign = new System.Windows.Forms.PictureBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSensorRead = new System.Windows.Forms.TabPage();
            this.ctrSensorReading1 = new Spoken_Gloves_Project.ctrSensorReading();
            this.btnAddSign = new Spoken_Gloves_Project.RoundButton();
            this.tbAddPic = new System.Windows.Forms.TabPage();
            this.bttnAddSign = new Spoken_Gloves_Project.RoundButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbSensorRead.SuspendLayout();
            this.tbAddPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSign
            // 
            this.pictureBoxSign.Location = new System.Drawing.Point(417, 170);
            this.pictureBoxSign.Name = "pictureBoxSign";
            this.pictureBoxSign.Size = new System.Drawing.Size(442, 321);
            this.pictureBoxSign.TabIndex = 0;
            this.pictureBoxSign.TabStop = false;
            // 
            // llAdd
            // 
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(420, 507);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(168, 37);
            this.llAdd.TabIndex = 1;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "Add Photo";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Location = new System.Drawing.Point(718, 507);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(133, 37);
            this.llRemove.TabIndex = 2;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSensorRead);
            this.tabControl1.Controls.Add(this.tbAddPic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 933);
            this.tabControl1.TabIndex = 3;
            // 
            // tbSensorRead
            // 
            this.tbSensorRead.Controls.Add(this.ctrSensorReading1);
            this.tbSensorRead.Controls.Add(this.btnAddSign);
            this.tbSensorRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSensorRead.Location = new System.Drawing.Point(8, 51);
            this.tbSensorRead.Name = "tbSensorRead";
            this.tbSensorRead.Padding = new System.Windows.Forms.Padding(3);
            this.tbSensorRead.Size = new System.Drawing.Size(1285, 874);
            this.tbSensorRead.TabIndex = 0;
            this.tbSensorRead.Text = "Sensor Read";
            this.tbSensorRead.UseVisualStyleBackColor = true;
            // 
            // ctrSensorReading1
            // 
            this.ctrSensorReading1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrSensorReading1.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrSensorReading1.Location = new System.Drawing.Point(22, 25);
            this.ctrSensorReading1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrSensorReading1.Name = "ctrSensorReading1";
            this.ctrSensorReading1.Size = new System.Drawing.Size(1230, 722);
            this.ctrSensorReading1.TabIndex = 4;
            // 
            // btnAddSign
            // 
            this.btnAddSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnAddSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSign.Location = new System.Drawing.Point(946, 764);
            this.btnAddSign.Name = "btnAddSign";
            this.btnAddSign.Size = new System.Drawing.Size(306, 76);
            this.btnAddSign.TabIndex = 3;
            this.btnAddSign.Text = "Next";
            this.btnAddSign.UseVisualStyleBackColor = false;
            // 
            // tbAddPic
            // 
            this.tbAddPic.Controls.Add(this.bttnAddSign);
            this.tbAddPic.Controls.Add(this.pictureBoxSign);
            this.tbAddPic.Controls.Add(this.llRemove);
            this.tbAddPic.Controls.Add(this.llAdd);
            this.tbAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddPic.Location = new System.Drawing.Point(8, 51);
            this.tbAddPic.Name = "tbAddPic";
            this.tbAddPic.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddPic.Size = new System.Drawing.Size(1285, 874);
            this.tbAddPic.TabIndex = 1;
            this.tbAddPic.Text = "Add Picture";
            this.tbAddPic.UseVisualStyleBackColor = true;
            // 
            // bttnAddSign
            // 
            this.bttnAddSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAddSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.bttnAddSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAddSign.Location = new System.Drawing.Point(952, 768);
            this.bttnAddSign.Name = "bttnAddSign";
            this.bttnAddSign.Size = new System.Drawing.Size(306, 76);
            this.bttnAddSign.TabIndex = 4;
            this.bttnAddSign.Text = "Add Sign";
            this.bttnAddSign.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 933);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddSign";
            this.Text = "frmAddSign";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbSensorRead.ResumeLayout(false);
            this.tbAddPic.ResumeLayout(false);
            this.tbAddPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSign;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSensorRead;
        private System.Windows.Forms.TabPage tbAddPic;
        private RoundButton bttnAddSign;
        private ctrSensorReading ctrSensorReading1;
        private RoundButton btnAddSign;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
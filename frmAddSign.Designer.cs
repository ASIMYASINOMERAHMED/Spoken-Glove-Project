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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSign));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSignInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignText = new System.Windows.Forms.TextBox();
            this.tbSensorRead = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddSign = new Guna.UI2.WinForms.Guna2GradientButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUploadImage = new Spoken_Gloves_Project.RoundButton();
            this.txtImageLocation = new Spoken_Gloves_Project.RoundTextBox();
            this.ctrSensorReading1 = new Spoken_Gloves_Project.ctrSensorReading();
            this.tabControl1.SuspendLayout();
            this.tbSignInfo.SuspendLayout();
            this.tbSensorRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSignInfo);
            this.tabControl1.Controls.Add(this.tbSensorRead);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 897);
            this.tabControl1.TabIndex = 0;
            // 
            // tbSignInfo
            // 
            this.tbSignInfo.Controls.Add(this.btnNext);
            this.tbSignInfo.Controls.Add(this.label1);
            this.tbSignInfo.Controls.Add(this.btnUploadImage);
            this.tbSignInfo.Controls.Add(this.txtImageLocation);
            this.tbSignInfo.Controls.Add(this.label2);
            this.tbSignInfo.Controls.Add(this.txtSignText);
            this.tbSignInfo.ImageIndex = 0;
            this.tbSignInfo.Location = new System.Drawing.Point(8, 70);
            this.tbSignInfo.Name = "tbSignInfo";
            this.tbSignInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbSignInfo.Size = new System.Drawing.Size(1032, 819);
            this.tbSignInfo.TabIndex = 1;
            this.tbSignInfo.Text = "Sign Info";
            this.tbSignInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.AnimatedGIF = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNext.Location = new System.Drawing.Point(693, 606);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(305, 70);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sign Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sign Image";
            // 
            // txtSignText
            // 
            this.txtSignText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignText.Location = new System.Drawing.Point(35, 154);
            this.txtSignText.Multiline = true;
            this.txtSignText.Name = "txtSignText";
            this.txtSignText.Size = new System.Drawing.Size(963, 174);
            this.txtSignText.TabIndex = 3;
            this.txtSignText.Validating += new System.ComponentModel.CancelEventHandler(this.txtSignText_Validating);
            // 
            // tbSensorRead
            // 
            this.tbSensorRead.Controls.Add(this.btnAddSign);
            this.tbSensorRead.Controls.Add(this.ctrSensorReading1);
            this.tbSensorRead.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSensorRead.ImageIndex = 1;
            this.tbSensorRead.Location = new System.Drawing.Point(8, 70);
            this.tbSensorRead.Name = "tbSensorRead";
            this.tbSensorRead.Padding = new System.Windows.Forms.Padding(3);
            this.tbSensorRead.Size = new System.Drawing.Size(1032, 819);
            this.tbSensorRead.TabIndex = 0;
            this.tbSensorRead.Text = "Sensor Read";
            this.tbSensorRead.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnAddSign
            // 
            this.btnAddSign.Animated = true;
            this.btnAddSign.AnimatedGIF = true;
            this.btnAddSign.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSign.BorderRadius = 20;
            this.btnAddSign.BorderThickness = 1;
            this.btnAddSign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSign.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSign.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnAddSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSign.ForeColor = System.Drawing.Color.White;
            this.btnAddSign.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddSign.Location = new System.Drawing.Point(657, 724);
            this.btnAddSign.Name = "btnAddSign";
            this.btnAddSign.Size = new System.Drawing.Size(348, 70);
            this.btnAddSign.TabIndex = 32;
            this.btnAddSign.Text = "Add Sign";
            this.btnAddSign.Click += new System.EventHandler(this.btnAddSign_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ApplicationType.png");
            this.imageList1.Images.SetKeyName(1, "usb_internet_data_card.png");
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackgroundImage = global::Spoken_Gloves_Project.Properties.Resources.more_vertical;
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadImage.Location = new System.Drawing.Point(940, 440);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(54, 43);
            this.btnUploadImage.TabIndex = 17;
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImageLocation.Enabled = false;
            this.txtImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageLocation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtImageLocation.Location = new System.Drawing.Point(196, 434);
            this.txtImageLocation.Multiline = true;
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(802, 53);
            this.txtImageLocation.TabIndex = 16;
            this.txtImageLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtImageLocation_Validating);
            // 
            // ctrSensorReading1
            // 
            this.ctrSensorReading1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrSensorReading1.Location = new System.Drawing.Point(-60, 0);
            this.ctrSensorReading1.Name = "ctrSensorReading1";
            this.ctrSensorReading1.Size = new System.Drawing.Size(1100, 718);
            this.ctrSensorReading1.TabIndex = 21;
            // 
            // frmAddSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1048, 897);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sign";
            this.Load += new System.EventHandler(this.frmAddSign_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbSignInfo.ResumeLayout(false);
            this.tbSignInfo.PerformLayout();
            this.tbSensorRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSensorRead;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tbSignInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSignText;
        private RoundButton btnUploadImage;
        private RoundTextBox txtImageLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private ctrSensorReading ctrSensorReading1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddSign;
        private System.Windows.Forms.ImageList imageList1;
    }
}
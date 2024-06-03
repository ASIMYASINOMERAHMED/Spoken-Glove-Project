namespace Spoken_Gloves_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSpeak1 = new System.Windows.Forms.Button();
            this.lbText1 = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.picBoxSign = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddSign1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExit11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnStart11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStop11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.picboxSign1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSign1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(1419, 747);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(110, 51);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Text";
            this.lbText.TextChanged += new System.EventHandler(this.lbText_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(477, 297);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnSpeak1
            // 
            this.btnSpeak1.BackgroundImage = global::Spoken_Gloves_Project.Properties.Resources.speaker;
            this.btnSpeak1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpeak1.Location = new System.Drawing.Point(362, 611);
            this.btnSpeak1.Name = "btnSpeak1";
            this.btnSpeak1.Size = new System.Drawing.Size(46, 42);
            this.btnSpeak1.TabIndex = 26;
            this.btnSpeak1.UseVisualStyleBackColor = true;
            this.btnSpeak1.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.BackColor = System.Drawing.Color.Transparent;
            this.lbText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText1.Location = new System.Drawing.Point(544, 611);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(106, 42);
            this.lbText1.TabIndex = 1;
            this.lbText1.Text = "[???]";
            this.lbText1.TextChanged += new System.EventHandler(this.lbText_TextChanged);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeak.BackgroundImage = global::Spoken_Gloves_Project.Properties.Resources.speaker;
            this.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpeak.Location = new System.Drawing.Point(692, 654);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(74, 65);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // picBoxSign
            // 
            this.picBoxSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxSign.BackColor = System.Drawing.SystemColors.Highlight;
            this.picBoxSign.Image = global::Spoken_Gloves_Project.Properties.Resources.project_duration;
            this.picBoxSign.Location = new System.Drawing.Point(692, 154);
            this.picBoxSign.Name = "picBoxSign";
            this.picBoxSign.Size = new System.Drawing.Size(632, 458);
            this.picBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSign.TabIndex = 0;
            this.picBoxSign.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddSign1
            // 
            this.btnAddSign1.Animated = true;
            this.btnAddSign1.AnimatedGIF = true;
            this.btnAddSign1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSign1.BorderRadius = 20;
            this.btnAddSign1.BorderThickness = 1;
            this.btnAddSign1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSign1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSign1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSign1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSign1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSign1.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnAddSign1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSign1.ForeColor = System.Drawing.Color.White;
            this.btnAddSign1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddSign1.Location = new System.Drawing.Point(12, 356);
            this.btnAddSign1.Name = "btnAddSign1";
            this.btnAddSign1.Size = new System.Drawing.Size(477, 70);
            this.btnAddSign1.TabIndex = 27;
            this.btnAddSign1.Text = "Add Sign";
            this.btnAddSign1.Click += new System.EventHandler(this.btnAddSign_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Animated = true;
            this.btnUpdate1.AnimatedGIF = true;
            this.btnUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate1.BorderRadius = 20;
            this.btnUpdate1.BorderThickness = 1;
            this.btnUpdate1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate1.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnUpdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate1.ForeColor = System.Drawing.Color.White;
            this.btnUpdate1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnUpdate1.Location = new System.Drawing.Point(15, 451);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(474, 70);
            this.btnUpdate1.TabIndex = 28;
            this.btnUpdate1.Text = "Update Sign";
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Animated = true;
            this.btnDelete1.AnimatedGIF = true;
            this.btnDelete1.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete1.BorderRadius = 20;
            this.btnDelete1.BorderThickness = 1;
            this.btnDelete1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete1.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDelete1.Location = new System.Drawing.Point(15, 546);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(474, 70);
            this.btnDelete1.TabIndex = 29;
            this.btnDelete1.Text = "Delete Sign";
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit11
            // 
            this.btnExit11.Animated = true;
            this.btnExit11.AnimatedGIF = true;
            this.btnExit11.BackColor = System.Drawing.Color.Transparent;
            this.btnExit11.BorderRadius = 20;
            this.btnExit11.BorderThickness = 1;
            this.btnExit11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit11.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit11.FillColor = System.Drawing.Color.SandyBrown;
            this.btnExit11.FillColor2 = System.Drawing.Color.Crimson;
            this.btnExit11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit11.ForeColor = System.Drawing.Color.White;
            this.btnExit11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnExit11.Location = new System.Drawing.Point(12, 793);
            this.btnExit11.Name = "btnExit11";
            this.btnExit11.Size = new System.Drawing.Size(477, 70);
            this.btnExit11.TabIndex = 30;
            this.btnExit11.Text = "Exit";
            this.btnExit11.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDelete1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnExit11);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUpdate1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAddSign1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.SteelBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DeepSkyBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Aquamarine;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(513, 934);
            this.guna2CustomGradientPanel1.TabIndex = 31;
            // 
            // btnStart11
            // 
            this.btnStart11.Animated = true;
            this.btnStart11.AnimatedGIF = true;
            this.btnStart11.BackColor = System.Drawing.Color.Transparent;
            this.btnStart11.BorderRadius = 20;
            this.btnStart11.BorderThickness = 1;
            this.btnStart11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart11.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart11.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnStart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart11.ForeColor = System.Drawing.Color.White;
            this.btnStart11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnStart11.Location = new System.Drawing.Point(149, 27);
            this.btnStart11.Name = "btnStart11";
            this.btnStart11.Size = new System.Drawing.Size(348, 70);
            this.btnStart11.TabIndex = 31;
            this.btnStart11.Text = "Start";
            this.btnStart11.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop11
            // 
            this.btnStop11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop11.Animated = true;
            this.btnStop11.AnimatedGIF = true;
            this.btnStop11.BackColor = System.Drawing.Color.Transparent;
            this.btnStop11.BorderRadius = 20;
            this.btnStop11.BorderThickness = 1;
            this.btnStop11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop11.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop11.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btnStop11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop11.ForeColor = System.Drawing.Color.White;
            this.btnStop11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnStop11.Location = new System.Drawing.Point(694, 27);
            this.btnStop11.Name = "btnStop11";
            this.btnStop11.Size = new System.Drawing.Size(348, 70);
            this.btnStop11.TabIndex = 32;
            this.btnStop11.Text = "Stop";
            this.btnStop11.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.picboxSign1);
            this.guna2GradientPanel1.Controls.Add(this.lbText1);
            this.guna2GradientPanel1.Controls.Add(this.btnSpeak1);
            this.guna2GradientPanel1.Controls.Add(this.btnStop11);
            this.guna2GradientPanel1.Controls.Add(this.btnStart11);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.MediumSpringGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(513, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1173, 934);
            this.guna2GradientPanel1.TabIndex = 32;
            // 
            // picboxSign1
            // 
            this.picboxSign1.BackColor = System.Drawing.Color.Transparent;
            this.picboxSign1.BorderRadius = 20;
            this.picboxSign1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxSign1.FillColor = System.Drawing.Color.Transparent;
            this.picboxSign1.ImageRotate = 0F;
            this.picboxSign1.Location = new System.Drawing.Point(362, 154);
            this.picboxSign1.Name = "picboxSign1";
            this.picboxSign1.Size = new System.Drawing.Size(478, 413);
            this.picboxSign1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSign1.TabIndex = 33;
            this.picboxSign1.TabStop = false;
            this.picboxSign1.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 934);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Hand Signs Gesture Recognition Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSign1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSign;
        private System.Windows.Forms.Label lbText;
        private RoundButton btnAddSign;
        private RoundButton btnUpdate;
        private RoundButton btnDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RoundButton btnExit;
        private System.Windows.Forms.Button btnSpeak;
        private RoundButton btnStart;
        private RoundButton btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Button btnSpeak1;
        private Guna.UI2.WinForms.Guna2GradientButton btnStop11;
        private Guna.UI2.WinForms.Guna2GradientButton btnStart11;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit11;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddSign1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox picboxSign1;
    }
}


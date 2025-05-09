namespace workglass
{
    partial class signin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            pictureBoxlogo = new PictureBox();
            labeltitle = new Label();
            pictureBoxlogo2 = new PictureBox();
            btnlogin = new Button();
            panel1 = new Panel();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            labelpassword = new Label();
            labelname = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.BackColor = SystemColors.HotTrack;
            pictureBoxlogo.Dock = DockStyle.Top;
            pictureBoxlogo.Location = new Point(0, 0);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(1354, 359);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 0;
            pictureBoxlogo.TabStop = false;
            pictureBoxlogo.Click += pictureBoxlogo_Click;
            // 
            // labeltitle
            // 
            labeltitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labeltitle.BackColor = SystemColors.Control;
            labeltitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitle.ForeColor = SystemColors.MenuHighlight;
            labeltitle.Location = new Point(0, 359);
            labeltitle.Name = "labeltitle";
            labeltitle.RightToLeft = RightToLeft.Yes;
            labeltitle.Size = new Size(1354, 50);
            labeltitle.TabIndex = 1;
            labeltitle.Text = "مرحبا بكم فى ادارة ورشة الزجاج";
            labeltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxlogo2
            // 
            pictureBoxlogo2.Image = (Image)resources.GetObject("pictureBoxlogo2.Image");
            pictureBoxlogo2.Location = new Point(489, 0);
            pictureBoxlogo2.Name = "pictureBoxlogo2";
            pictureBoxlogo2.Size = new Size(379, 356);
            pictureBoxlogo2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo2.TabIndex = 3;
            pictureBoxlogo2.TabStop = false;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Lime;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(121, 159);
            btnlogin.Name = "btnlogin";
            btnlogin.RightToLeft = RightToLeft.Yes;
            btnlogin.Size = new Size(150, 40);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "تسجيل الدخول";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += buttonlogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(labelpassword);
            panel1.Controls.Add(labelname);
            panel1.Location = new Point(489, 431);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 202);
            panel1.TabIndex = 9;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(21, 108);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(200, 27);
            txtpassword.TabIndex = 11;
            txtpassword.TextAlign = HorizontalAlignment.Right;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(21, 42);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(200, 27);
            txtusername.TabIndex = 10;
            txtusername.TextAlign = HorizontalAlignment.Right;
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(256, 111);
            labelpassword.Name = "labelpassword";
            labelpassword.RightToLeft = RightToLeft.Yes;
            labelpassword.Size = new Size(70, 20);
            labelpassword.TabIndex = 9;
            labelpassword.Text = "Password";
            labelpassword.Click += txtpassword_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(256, 45);
            labelname.Name = "labelname";
            labelname.RightToLeft = RightToLeft.Yes;
            labelname.Size = new Size(82, 20);
            labelname.TabIndex = 8;
            labelname.Text = "User Name";
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 953);
            Controls.Add(panel1);
            Controls.Add(pictureBoxlogo2);
            Controls.Add(labeltitle);
            Controls.Add(pictureBoxlogo);
            Name = "signin";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxlogo;
        private Label labeltitle;
        private PictureBox pictureBoxlogo2;
        private Button btnlogin;
        private Panel panel1;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label labelpassword;
        private Label labelname;
    }
}

namespace workglass
{
    partial class owner
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            lNameTxt = new TextBox();
            possitionTxt = new TextBox();
            salaryTxt = new TextBox();
            fNameTxt = new TextBox();
            phoneTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 29.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(213, 97);
            label1.Name = "label1";
            label1.Size = new Size(181, 66);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(767, 37);
            button1.Name = "button1";
            button1.Size = new Size(165, 47);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(167, 286);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 131);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(87, 37);
            button4.Name = "button4";
            button4.Size = new Size(165, 47);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(303, 37);
            button3.Name = "button3";
            button3.Size = new Size(165, 47);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(527, 37);
            button2.Name = "button2";
            button2.Size = new Size(165, 47);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 423);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1330, 518);
            dataGridView1.TabIndex = 3;
            // 
            // lNameTxt
            // 
            lNameTxt.Location = new Point(600, 97);
            lNameTxt.Name = "lNameTxt";
            lNameTxt.Size = new Size(259, 27);
            lNameTxt.TabIndex = 4;
            // 
            // possitionTxt
            // 
            possitionTxt.Location = new Point(600, 151);
            possitionTxt.Name = "possitionTxt";
            possitionTxt.Size = new Size(259, 27);
            possitionTxt.TabIndex = 4;
            // 
            // salaryTxt
            // 
            salaryTxt.Location = new Point(600, 200);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(259, 27);
            salaryTxt.TabIndex = 4;
            // 
            // fNameTxt
            // 
            fNameTxt.Location = new Point(600, 53);
            fNameTxt.Name = "fNameTxt";
            fNameTxt.Size = new Size(259, 27);
            fNameTxt.TabIndex = 4;
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(600, 246);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(259, 27);
            phoneTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(990, 54);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 5;
            label2.Text = "Frist name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(990, 93);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 5;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(990, 151);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 5;
            label4.Text = "Possition";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(990, 188);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 5;
            label5.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(990, 228);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // owner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1354, 953);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(possitionTxt);
            Controls.Add(phoneTxt);
            Controls.Add(fNameTxt);
            Controls.Add(salaryTxt);
            Controls.Add(lNameTxt);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "owner";
            Text = "owner";
            Load += owner_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox lNameTxt;
        private TextBox possitionTxt;
        private TextBox salaryTxt;
        private TextBox fNameTxt;
        private TextBox phoneTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
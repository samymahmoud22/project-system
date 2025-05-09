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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            userid = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(597, 83);
            label1.Name = "label1";
            label1.Size = new Size(137, 50);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(32, 60);
            button1.Name = "button1";
            button1.Size = new Size(165, 47);
            button1.TabIndex = 1;
            button1.Text = "Manage Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(3, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 564);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(32, 428);
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
            button3.Location = new Point(32, 311);
            button3.Name = "button3";
            button3.Size = new Size(165, 47);
            button3.TabIndex = 4;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(32, 181);
            button2.Name = "button2";
            button2.Size = new Size(165, 47);
            button2.TabIndex = 3;
            button2.Text = "View Reports";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userid, username, role, status });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(350, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1006, 788);
            dataGridView1.TabIndex = 3;
            // 
            // userid
            // 
            userid.HeaderText = "User ID";
            userid.MinimumWidth = 6;
            userid.Name = "userid";
            // 
            // username
            // 
            username.HeaderText = "User Name";
            username.MinimumWidth = 6;
            username.Name = "username";
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // owner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 953);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "owner";
            Text = "owner";
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
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn status;
    }
}
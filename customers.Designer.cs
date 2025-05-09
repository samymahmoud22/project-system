namespace workglass
{
    partial class customers
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            customerid = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            button4 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(543, 18);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(118, 87);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 1;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(919, 87);
            button2.Name = "button2";
            button2.Size = new Size(181, 52);
            button2.TabIndex = 2;
            button2.Text = "Delete Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(543, 87);
            button3.Name = "button3";
            button3.Size = new Size(181, 52);
            button3.TabIndex = 3;
            button3.Text = "Edit Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customerid, name, phone, email });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(0, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1354, 673);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // customerid
            // 
            customerid.HeaderText = "customer ID";
            customerid.MinimumWidth = 6;
            customerid.Name = "customerid";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // phone
            // 
            phone.HeaderText = "phone Number";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Location = new Point(1158, 190);
            button4.Name = "button4";
            button4.Size = new Size(135, 41);
            button4.TabIndex = 5;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(564, 190);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by name or email";
            textBox1.Size = new Size(536, 41);
            textBox1.TabIndex = 6;
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 953);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "customers";
            Text = "customerForm2";
            Load += customers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn customerid;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private Button button4;
        private TextBox textBox1;
    }
}
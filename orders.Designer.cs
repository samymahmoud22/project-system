namespace workglass
{
    partial class orders
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
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            type = new DataGridViewComboBoxColumn();
            thickness = new DataGridViewComboBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            width = new DataGridViewTextBoxColumn();
            area = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(629, 353);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by name or category";
            textBox1.Size = new Size(517, 41);
            textBox1.TabIndex = 14;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Location = new Point(1207, 355);
            button4.Name = "button4";
            button4.Size = new Size(135, 41);
            button4.TabIndex = 13;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(594, 266);
            button3.Name = "button3";
            button3.Size = new Size(181, 52);
            button3.TabIndex = 12;
            button3.Text = "Edit Item";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(965, 266);
            button2.Name = "button2";
            button2.Size = new Size(181, 52);
            button2.TabIndex = 11;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(217, 266);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 10;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(584, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 50);
            label1.TabIndex = 9;
            label1.Text = "Inventory";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { type, thickness, lenght, width, area, price, totalprice });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 533);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1354, 411);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1207, 84);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(135, 41);
            label2.TabIndex = 16;
            label2.Text = "رقم الاوردر";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(217, 84);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(929, 41);
            textBox2.TabIndex = 17;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1207, 159);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(135, 41);
            label3.TabIndex = 18;
            label3.Text = "اسم العميل";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(217, 159);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(929, 41);
            textBox3.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(896, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1207, 218);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(135, 41);
            label4.TabIndex = 21;
            label4.Text = "التاريخ";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1207, 973);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(135, 41);
            label5.TabIndex = 22;
            label5.Text = "الخصم";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(594, 973);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(200, 41);
            label6.TabIndex = 23;
            label6.Text = "السعر بعد الخصم";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(831, 973);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(349, 41);
            textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(217, 973);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(349, 41);
            textBox5.TabIndex = 25;
            // 
            // type
            // 
            type.HeaderText = "نوع الزجاج";
            type.MinimumWidth = 6;
            type.Name = "type";
            // 
            // thickness
            // 
            thickness.HeaderText = "السمك";
            thickness.MinimumWidth = 6;
            thickness.Name = "thickness";
            // 
            // lenght
            // 
            lenght.HeaderText = "الطول";
            lenght.MinimumWidth = 6;
            lenght.Name = "lenght";
            // 
            // width
            // 
            width.HeaderText = "العرض";
            width.MinimumWidth = 6;
            width.Name = "width";
            // 
            // area
            // 
            area.HeaderText = "المساحة";
            area.MinimumWidth = 6;
            area.Name = "area";
            // 
            // price
            // 
            price.HeaderText = "السعر للمتر";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // totalprice
            // 
            totalprice.HeaderText = "السعر الاجمالى";
            totalprice.MinimumWidth = 6;
            totalprice.Name = "totalprice";
            // 
            // orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 1055);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "orders";
            Text = "orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewComboBoxColumn type;
        private DataGridViewComboBoxColumn thickness;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn width;
        private DataGridViewTextBoxColumn area;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn totalprice;
    }
}
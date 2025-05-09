namespace workglass
{
    partial class inventory
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
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            itemid = new DataGridViewTextBoxColumn();
            itemname = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(545, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 50);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(168, 129);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 1;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(916, 129);
            button2.Name = "button2";
            button2.Size = new Size(181, 52);
            button2.TabIndex = 2;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(545, 129);
            button3.Name = "button3";
            button3.Size = new Size(181, 52);
            button3.TabIndex = 3;
            button3.Text = "Edit Item";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { itemid, itemname, category, Quantity, price, supplier });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1354, 649);
            dataGridView1.TabIndex = 4;
            // 
            // itemid
            // 
            itemid.HeaderText = "Item ID";
            itemid.MinimumWidth = 6;
            itemid.Name = "itemid";
            // 
            // itemname
            // 
            itemname.HeaderText = "Item Name";
            itemname.MinimumWidth = 6;
            itemname.Name = "itemname";
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // supplier
            // 
            supplier.HeaderText = "supplier";
            supplier.MinimumWidth = 6;
            supplier.Name = "supplier";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(580, 233);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by name or category";
            textBox1.Size = new Size(517, 41);
            textBox1.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Location = new Point(1158, 235);
            button4.Name = "button4";
            button4.Size = new Size(135, 41);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // inventory
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
            Name = "inventory";
            Text = "inventory";
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
        private DataGridViewTextBoxColumn itemid;
        private DataGridViewTextBoxColumn itemname;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn supplier;
        private TextBox textBox1;
        private Button button4;
    }
}
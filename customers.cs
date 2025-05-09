using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace workglass
{
    public partial class customers : Form
    {
        string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=orders;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { "@customerID", "@customerName", "@customerEmail", "@customerPhone" };
            dataGridView1.Rows.Add(row);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                dataGridView1.CurrentRow.Cells[1].Value = "Updated Name";
                dataGridView1.CurrentRow.Cells[2].Value = "0111222333";
                dataGridView1.CurrentRow.Cells[3].Value = "Alexandria";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {

        }
    }
}

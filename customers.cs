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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workglass
{
    public partial class customers : Form
    {
        

       
        public customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM Customers";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (CustomerName,CustomerEmail,CustomerPhone) VALUES (@CustomerName,@CustomerEmail,@CustomerPhone)";
                SqlCommand cmd = new SqlCommand(query, conn);

                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dataGridView1.ClearSelection();
                    return;
                }

                cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
                cmd.Parameters.AddWithValue("@CustomerEmail", textBox3.Text);
                cmd.Parameters.AddWithValue("@CustomerPhone", int.Parse(textBox4.Text));
                

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تمت الإضافة بنجاح");
                LoadData();
            }

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
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM Customers";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}

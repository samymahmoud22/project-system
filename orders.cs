using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workglass
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void orders_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM Orders";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM Orders";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    textBox2.Clear();
                    textBox3.Clear();                
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (CustomerID,TotalPrice,OrderDate) VALUES (@CustomerID,@TotalPrice,@OrderDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول");
                    textBox2.Clear();
                    textBox3.Clear();
                    dataGridView1.ClearSelection();
                    return;
                }

                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@TotalPrice", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تمت الإضافة بنجاح");
                LoadData();
            }
        }
    }
}

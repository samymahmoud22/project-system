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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workglass
{
    public partial class OrderItems : Form
    {
        public OrderItems()
        {
            InitializeComponent();
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM OrderItems";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM OrderItems WHERE OrderID LIKE @search";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox6.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                textBox6.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM OrderItems";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox6.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("الرجاء ملئ الحقل");
                    textBox1.Clear();
                    LoadData();
                    return;
                }

                {
                    string Dquery = "DELETE FROM OrderItems WHERE OrderID=@OrderID";
                    SqlCommand cmd = new SqlCommand(Dquery, conn);
                    cmd.Parameters.AddWithValue("@OrderID", int.Parse(textBox6.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("تم الحذف بنجاح");
                    LoadData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM OrderItems";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox6.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO OrderItems (OrderID,ItemID,Quantity,UnitPrice) VALUES (@OrderID,@ItemID,@Quantity,@UnitPrice)";
                SqlCommand cmd = new SqlCommand(query, conn);

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dataGridView1.ClearSelection();
                    return;
                }


                cmd.Parameters.AddWithValue("@OrderID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(textBox4.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تمت الإضافة بنجاح");
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM OrderItems"; 

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox6.Clear();
                    dataGridView1.ClearSelection();
                }
            }

            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE OrderItems SET Quantity = @Quantity, UnitPrice = @UnitPrice WHERE OrderID = @OrderID AND ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@OrderID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox2.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم التعديل بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على السطر المحدد.");
                }

                LoadData();
            }
        }
    }
}

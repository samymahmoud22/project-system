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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM Items";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Items (ItemName,ItemCategory,ItemQuantity,Price) VALUES (@ItemName,@ItemCategory,@ItemQuantity,@Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    dataGridView1.ClearSelection();
                    return;
                }

                cmd.Parameters.AddWithValue("@ItemName", textBox2.Text);
                cmd.Parameters.AddWithValue("@ItemCategory", textBox3.Text);
                cmd.Parameters.AddWithValue("@ItemQuantity", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Price", int.Parse(textBox5.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تمت الإضافة بنجاح");
                LoadData();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM Items";

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
                    textBox5.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            if (string.IsNullOrEmpty(textBox1.Text) ||
     string.IsNullOrEmpty(textBox2.Text) ||
     string.IsNullOrEmpty(textBox3.Text) ||
     string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول");
                return;
            }

            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET ItemName = @ItemName,  ItemCategory= @ItemCategory, ItemQuantity =@ItemQuantity ,Price =@Price WHERE ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ItemName", textBox2.Text);
                cmd.Parameters.AddWithValue("@ItemCategory", textBox3.Text);
                cmd.Parameters.AddWithValue("@ItemQuantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", textBox5.Text);
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox1.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم التعديل بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على العميل المحدد.");
                }

                LoadData();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM Items";
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
                    textBox5.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("الرجاء ملئ الحقل");
                    textBox1.Clear();
                    LoadData();
                    return;
                }

                {
                    string Dquery = "DELETE FROM Items WHERE ItemID=@ItemID";
                    SqlCommand cmd = new SqlCommand(Dquery, conn);
                    cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox1.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("تم الحذف بنجاح");
                    LoadData();
                }
            }

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM Items";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM Items WHERE ItemName LIKE @search or ItemCategory LIKE @search ";
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
    }
}

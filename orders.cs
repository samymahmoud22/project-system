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

        private void button2_Click(object sender, EventArgs e)
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
                    string Dquery = "DELETE FROM Orders WHERE OrderID=@OrderID";
                    SqlCommand cmd = new SqlCommand(Dquery, conn);
                    cmd.Parameters.AddWithValue("@OrderID", int.Parse(textBox1.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("تم الحذف بنجاح");
                    LoadData();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            string query = "SELECT * FROM Orders WHERE CustomerID LIKE @search";
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("من فضلك أدخل رقم الأوردر.");
                return;
            }

            int orderId = Convert.ToInt32(textBox7.Text);
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    SqlCommand getItemsCmd = new SqlCommand(
                        "SELECT ItemID, Quantity FROM OrderItems WHERE OrderID = @OrderID",
                        conn, transaction
                    );
                    getItemsCmd.Parameters.AddWithValue("@OrderID", orderId);

                    List<(int itemId, int qty)> orderItems = new List<(int, int)>();

                    using (SqlDataReader reader = getItemsCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderItems.Add((reader.GetInt32(0), reader.GetInt32(1)));
                        }
                    }

                    if (orderItems.Count == 0)
                    {
                        MessageBox.Show("الطلب لا يحتوي على أي أصناف.");
                        transaction.Rollback();
                        return;
                    }


                    foreach (var item in orderItems)
                    {
                        SqlCommand checkQtyCmd = new SqlCommand(
                            "SELECT ItemQuantity FROM Items WHERE ItemID = @ItemID",
                            conn, transaction
                        );
                        checkQtyCmd.Parameters.AddWithValue("@ItemID", item.itemId);

                        int availableQty = Convert.ToInt32(checkQtyCmd.ExecuteScalar());

                        if (availableQty < item.qty)
                        {
                            MessageBox.Show($"الكمية غير كافية للمنتج رقم {item.itemId}. المتاح: {availableQty}، المطلوب: {item.qty}");
                            transaction.Rollback();
                            return;
                        }
                    }


                    foreach (var item in orderItems)
                    {
                        SqlCommand updateQtyCmd = new SqlCommand(
                            "UPDATE Items SET ItemQuantity = ItemQuantity - @Qty WHERE ItemID = @ItemID",
                            conn, transaction
                        );
                        updateQtyCmd.Parameters.AddWithValue("@Qty", item.qty);
                        updateQtyCmd.Parameters.AddWithValue("@ItemID", item.itemId);
                        updateQtyCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("تم إنهاء الطلب وتحديث المخزون بنجاح.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("خطأ: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

                    // نفترض ترتيب الـ TextBoxes كالتالي:
                    // textBox1 = OrderID (مخفي أو غير قابل للتعديل)
                    // textBox2 = CustomerID
                    // textBox3 = TotalPrice
                    // dateTimePicker1 = OrderDate

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    dateTimePicker1.Value = DateTime.Today;

                    dataGridView1.ClearSelection();
                }
            }
            if (string.IsNullOrEmpty(textBox1.Text) ||
        string.IsNullOrEmpty(textBox2.Text) ||
        string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("يرجى ملء كل الحقول المطلوبة");
                return;
            }

            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orders SET CustomerID = @CustomerID, TotalPrice = @TotalPrice, OrderDate = @OrderDate WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@TotalPrice", decimal.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@OrderID", int.Parse(textBox1.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم تعديل الطلب بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على الطلب");
                }

                LoadData();
            }
        
        }
    }
}

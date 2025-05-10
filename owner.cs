using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace workglass
{
    public partial class owner : Form
    {
        public owner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM emp";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    fNameTxt.Clear();
                    lNameTxt.Clear();
                    salaryTxt.Clear();
                    phoneTxt.Clear();
                    possitionTxt.Clear();
                    dataGridView1.ClearSelection();
                }
            }
            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO emp (fristName,lastName,salary, possition, phone) VALUES (@fristName, @lastName, @salary, @possition, @phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (string.IsNullOrEmpty(fNameTxt.Text) || string.IsNullOrEmpty(lNameTxt.Text) || string.IsNullOrEmpty(salaryTxt.Text) || string.IsNullOrEmpty(phoneTxt.Text) || string.IsNullOrEmpty(possitionTxt.Text))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول");
                    fNameTxt.Clear();
                    lNameTxt.Clear();
                    salaryTxt.Clear();
                    phoneTxt.Clear();
                    possitionTxt.Clear();
                    dataGridView1.ClearSelection();
                    return;
                }
                cmd.Parameters.AddWithValue("@fristName", fNameTxt.Text);
                cmd.Parameters.AddWithValue("@lastName", lNameTxt.Text);
                cmd.Parameters.AddWithValue("@salary", int.Parse(salaryTxt.Text));
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneTxt.Text));
                cmd.Parameters.AddWithValue("@possition", possitionTxt.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تمت الإضافة بنجاح");
                LoadData();
            }
         }
           

        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports Page.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Settings Page.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            signin SigninForm = new signin();
            SigninForm.Show();
            this.Close();
        }

        private void owner_Load(object sender, EventArgs e)
        {
            void LoadData()
            {
                string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";
                string query = "SELECT * FROM emp";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            LoadData();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }


        private void buttonlogin_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            string password = txtpassword.Text;

            string connectionString = "Data Source=WINDOWS-93BUFTM\\SQLEXPRESS01;Initial Catalog=workGlass;Integrated Security=True;Encrypt=False";




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    conn.Open();

                    string query = "SELECT role FROM users WHERE userName = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);


                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {

                            string role = result.ToString();

                            if (role == "owner")
                            {

                                owner ownerForm = new owner();
                                ownerForm.Show();
                                this.Hide();
                            }
                            else if (role == "main")
                            {

                                mainForm2 mainForm = new mainForm2();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                txtusername.Clear();
                                txtusername.Focus();
                                txtpassword.Clear();
                                MessageBox.Show("Unknown role!");
                            }
                        }
                        else
                        {
                            txtusername.Clear();
                            txtpassword.Clear();
                            txtusername.Focus();
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxlogo_Click(object sender, EventArgs e)
        {

        }
    }
}
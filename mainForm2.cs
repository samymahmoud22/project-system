using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workglass
{
    public partial class mainForm2 : Form
    {
        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            owner ownerForm = new owner();
            ownerForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public mainForm2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainForm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orders ordersForm = new orders();
            ordersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customers customersForm = new customers();
            customersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventory inventoryForm = new inventory();
            inventoryForm.Show();
        }
    }
}

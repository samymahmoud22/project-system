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
    public partial class owner : Form
    {
        public owner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Manage Users Form.");

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
            Application.Exit();
        }
    }
   
}

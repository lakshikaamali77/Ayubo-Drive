using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsename.Text;
            string password = txtPassword.Text;
            
            if (username.Equals("ayubo") && password.Equals("456"))
            {
                Form2 hm = new Form2();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name or Password is Wrong!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

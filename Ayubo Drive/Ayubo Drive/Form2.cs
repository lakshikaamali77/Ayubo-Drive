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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            rentcalculation rentcalculation = new rentcalculation();
            rentcalculation.Show();
            
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.Show();   
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            longtour longtour = new longtour();
            longtour.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

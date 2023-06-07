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

namespace Ayubo_Drive
{
    public partial class Form3 : Form
    {
        SqlConnection con = null;
        public Form3()
        {
            con = new SqlConnection("Data Source=LAPTOP-1J2FUBSU\\MSSQLSERVER02;Initial Catalog=daytour;Integrated Security=True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            try
            {

                con.Open();
                label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from day_tour";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHireValue.Text == "")

                try
                {

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    string Hirevalue = txtHireValue.Text;
                    string vehicleno = txtVehicleNo.Text;
                    string packagetype = txtPackageType.Text;
                    string startkmreading = dateTimePicker1.Text;
                    string endkmreading = dateTimePicker2.Text;
                    string basichirechange = txtBasicHirechange.Text;
                    string waitingchange = txtWaiting.Text;
                    string extrakmchange = txtExrakm.Text;


                    cmd.CommandText = "INSERT INTO day_tour (hirevalue,vehivleno,packagetype,startkmreading,endkmreading,basichirechange,waitchange,exrakmchange) values ('" + Hirevalue + "', '" + vehicleno + "','" + packagetype + "','" + startkmreading + "','" + endkmreading + "','" + basichirechange + "','" + waitingchange + "','" + extrakmchange + "' )";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been inserted!");

                    txtHireValue.Clear();
                    txtVehicleNo.Clear();
                    txtPackageType.Clear();
                    txtStartkmre.Clear();
                    txtEndkmre.Clear();
                    txtBasicHirechange.Clear();
                    txtWaiting.Clear();
                    txtExrakm.Clear();
                    loadTable();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                // label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string hirevalue  = txtSerach.Text;
                cmd.CommandText = "select * from day_tour  where  name like  '%" + txtVehicleNo + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("Record not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

            //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    //  label3.Text = "Connection Successfull!";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int hirevalue  = Convert.ToInt32(txtHireValue.Text);
                    string vehicleno = txtVehicleNo.Text;
                    string packagetype  = txtPackageType.Text;
                    string starttime = dateTimePicker1.Text;
                    string endtime = dateTimePicker2.Text;
                    string basichirechange = txtBasicHirechange.Text;
                    string waitingchage = txtWaiting.Text;
                    string extrakmreading = txtExrakm.Text;

                    cmd.CommandText = "update day_tour  = '" + hirevalue + "', vehicleno ='" + vehicleno + "',packagetype ='"+packagetype+"', starttime ='"+starttime+"', endtime ='"+endtime+"', basichirechage= '"+basichirechange+"', waitingchage='"+waitingchage+"', extrakmreading ='"+extrakmreading+"'where id = '" + hirevalue + "' ";

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been Updated!");
                    txtHireValue.Clear();
                    txtVehicleNo.Clear();
                    txtPackageType.Clear();
                    txtBasicHirechange.Clear();
                    txtStartkmre.Clear();
                    txtEndkmre.Clear();
                    txtBasicHirechange.Clear();
                    txtWaiting.Clear();
                    txtExrakm.Clear();

                    //loadtable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}







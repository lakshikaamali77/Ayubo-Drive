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
    public partial class longtour : Form
    {
        SqlConnection con = null;


        public longtour()
        {
            con = new SqlConnection("Data Source=LAPTOP-1J2FUBSU\\MSSQLSERVER02;Initial Catalog=longtour;Integrated Security=True");
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                //label4.Text = "Connection Successfull!";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string hirevalue = txtHireValue.Text;
                string packagetype = txtPackagetype.Text;
                string startdate = dateTimePicker1.Text;
                string enddate = dateTimePicker2.Text;
                string startkmreading = txtStartkmreading.Text;
                string endkmreading = txtEndkmreading.Text;
                string basichirechange = txtBasichireChange.Text;
                string overnightstay = txtOvernihgt.Text;
                string exrakmchange = txtexrakmchange.Text;

                cmd.CommandText = "insert into long_reg (hirevalue,packagetype,starttime,endtime,startkmreading,endkmrading,basichirechange,overnightstay,exrakmchange) values ('" + hirevalue + "', '" + packagetype + "','" + startdate + "','" + enddate + "','" + startkmreading + "','" + endkmreading + "','" + basichirechange + "','" + overnightstay + "','" + exrakmchange + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted!");

                txtHireValue.Clear();
                txtPackagetype.Clear();
                //dateTimePicker1.Clear();
                //dateTimePicker2.Clear();
                txtStartkmreading.Clear();
                txtEndkmreading.Clear();
                txtBasichireChange.Clear();
                txtOvernihgt.Clear();
                txtexrakmchange.Clear();
                //loadtable();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                // label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string name = txtSearch.Text;
                cmd.CommandText = "select * from long_reg  where  name like  '%" + txtHireValue + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView2.DataSource = dt;

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
        }

        private void Startdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    //  label3.Text = "Connection Successfull!";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int hirevalue = Convert.ToInt32(txtHireValue.Text);
                    string packagetype = txtPackagetype.Text;
                    string startdate = dateTimePicker1.Text;
                    string enddate = dateTimePicker2.Text;
                    string startkmreading = txtStartkmreading.Text;
                    string endkmreading = txtEndkmreading.Text;
                    string basichire = txtBasichireChange.Text;
                    string overnihgt = txtOvernihgt.Text;
                    string extrakmchange = txtexrakmchange.Text;


                    cmd.CommandText = "update long_reg  set hirevalue = '" + hirevalue + "', packagetype ='" + packagetype + "', startdate='" + startdate + "',enddate='" + enddate + "', startkmrading ='" + startkmreading + "',basichirechange='" + basichire + "',overnightchange= '" + overnihgt + "',exrakmchange='" + extrakmchange + "' where hirevalue = '" + hirevalue + "' ";
                    //cmd.Parameters.Add(new OleDbParameter { Value = name });
                    //cmd.Parameters.Add(new OleDbParameter { Value = address });
                    //cmd.Parameters.Add(new OleDbParameter { Value = tp });
                    //cmd.Parameters.Add(new OleDbParameter { Value = id });
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been Updated!");
                    txtHireValue.Clear();
                    txtPackagetype.Clear();
                    //dateTimePicker1.Clear();
                    //dateTimePicker2.Clear();
                    txtStartkmreading.Clear();
                    txtEndkmreading.Clear();
                    txtBasichireChange.Clear();
                    txtOvernihgt.Clear();
                    txtexrakmchange.Clear();



                    //loadtable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void longtour_Load(object sender, EventArgs e)
        {

        }
    }
}
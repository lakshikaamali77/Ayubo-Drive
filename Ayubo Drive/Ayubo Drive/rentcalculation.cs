using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//1st step 

namespace Ayubo_Drive
{
    public partial class rentcalculation : Form
    {
        public SqlConnection con = null; //2nd step   


        
        public rentcalculation()
        {
            con = new SqlConnection("Data Source=LAPTOP-1J2FUBSU\\MSSQLSERVER02;Initial Catalog=rent;Integrated Security=True"); //step 3
            InitializeComponent(); 
        }
        private void Rentcalculatin (object sender, EventArgs e)
        { 

        }    



        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_VehicleNo.Text == "") 



                try
                {

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    string name = txt_VehicleNo.Text;
                    string renteddate = dateTimePicker1.Text;
                    string returndate = dateTimePicker2.Text; 
                    string  driver = txt_Drive.Text; 

                    int VehicleNo = Convert.ToInt32(txt_VehicleNo.Text);


                    cmd.CommandText = "INSERT INTO rentcalculation_reg  (vechicleno,renteddate,returndate,Driver) values ('" + VehicleNo + "', '" +renteddate  + "','"+returndate+"','"+VehicleNo+"' )";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been inserted!");

                    txt_VehicleNo.Clear();
                    dateTimePicker1.Show();
                    dateTimePicker2.Show();
                    //txt_Drive.Text.Clear();
                    loadTable();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
        }

        private void loadTable()

        {
            // get details from database table and display
            try
            {

                con.Open();
                label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from rentcalculation_reg where name like '%" + txt_VehicleNo + "%' ";
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


        private void rentcalculation_Load(object sender, EventArgs e)
        {
            
        }  




        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string name = txtSearch.Text;
                cmd.CommandText = "select * from rent calculation_reg where  name like  '%" +txt_VehicleNo +"%' ";
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

                    int vehicleno = Convert.ToInt32(txt_VehicleNo.Text);
                    string rentdate = dateTimePicker1.Text;
                    string returndate = dateTimePicker2.Text;
                    string driver = txt_Drive.Text;

                    cmd.CommandText = "update rentcalculation_reg  set vehicleno = '" + vehicleno + "', rentdate ='" + rentdate + "', returndate ='"+returndate+"', driver='"+driver+"' where id = '" + vehicleno + "' ";
                    //cmd.Parameters.Add(new OleDbParameter { Value = name });
                    //cmd.Parameters.Add(new OleDbParameter { Value = address });
                    //cmd.Parameters.Add(new OleDbParameter { Value = tp });
                    //cmd.Parameters.Add(new OleDbParameter { Value = id });
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been Updated!");
                    txt_VehicleNo.Clear();
                //    dateTimePicker1.Clear();
                //    txtlocation.Clear();

                //    loadtable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

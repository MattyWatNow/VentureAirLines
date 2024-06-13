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
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace SystemVenture
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");
        private void populate()
        {
            Conn.Open();
            string query = "Select * from PassengerTBL";
            SqlDataAdapter sas = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sas);
            var ds = new DataSet();
            sas.Fill(ds);

            PassengerDGV.DataSource = ds.Tables[0];

            Conn.Close();

        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PassengerRecord addpas = new PassengerRecord();
            addpas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassengerVBox.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "Delete from PassengerTBL where PassengerID =" + PassengerVBox.Text + ";";
                    SqlCommand cmdd = new SqlCommand(query, Conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Conn.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PassengerVBox.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTB.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PportTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTB.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            NatBox2.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            GND2.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassengerVBox.Text = "";
            PnameTB.Text = "";
            PportTb.Text = "";
            PaddTB.Text = "";
            NatBox2.SelectedItem = "";
            GND2.SelectedItem = "";
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (PassengerVBox.Text == "" || PnameTB.Text == "" || PportTb.Text == "" || PaddTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                    try
                    {
                        Conn.Open();
                        string query = "Update PassengerTBL set PassengerName='" + PnameTB.Text + "' " +
                            "', Passport= '" + PportTb.Text +
                            "', PassengerAddress='" + PaddTB.Text +
                            "', PassengerNTL='" + NatBox2.SelectedItem.ToString() +
                            "',Passenger Gender = '" + GND2.SelectedItem.ToString() +
                            "',PassengerPhone='" + PPhone2.Text +
                            " where PassengerID = " + PassengerVBox.Text + ";";

                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Passenger Recorded Successfully");
                        Conn.Close();
                        populate();
                    }
                catch (Exception Ex)
                {
                    MessageBox.Show("Missing Information");
                }
            
            }
        }
        }
    }


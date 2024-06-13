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

namespace SystemVenture
{
    public partial class PassengerRecord : Form
    {


        public PassengerRecord()
        {
            InitializeComponent();
        }


        private void RegButton_Click(object sender, EventArgs e)
        {

            if (PassengerID1.Text == "" || PassengerAdd1.Text == "" || PassengerName1.Text == "" || PassengerNo1.Text == "" || PassengerPhone1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");

                    SqlCommand van = new SqlCommand("INSERT INTO [dbo]." +
                        "[PassengerTBL] " +
                        "([PassengerID]," +
                        "[PassengerName]," +
                        "[Passport]" +
                        ",[PassengerAddress]," +
                        "[PassengerNTL]," +
                        "[Passenger Gender] " +
                        ",[PassengerPhone]) " +

                        " VALUES(" +
                        "'" + PassengerID1.Text + "', " +
                        "'" + PassengerName1.Text + "'," +
                        "'" + PassengerNo1.Text + "'," +
                        "'" + PassengerAdd1.Text + "', " +
                        "'" + NationalityBox1.SelectedItem + "', " +
                        "'" + GenderBox1.SelectedItem + "'," +
                        "'" + PassengerPhone1.Text + "')"
                        , Conn
                        );


                    Conn.Open();
                    van.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFlights viewPassenger = new ViewFlights();
            viewPassenger.Show();
            this.Hide();
        }

        private void PassengerRecord_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassengerID1.Text = "";
            PassengerName1.Text = "";
            PassengerNo1.Text = "";
            PassengerAdd1.Text = "";
            NationalityBox1.SelectedItem = "";
            GenderBox1.SelectedItem = "";
            PassengerPhone1.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home xd = new Home();
            xd.Show();
            this.Hide();
        }
    }
}
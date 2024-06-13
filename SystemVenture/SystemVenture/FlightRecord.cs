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
using System.Data.Common;

namespace SystemVenture
{
    public partial class FlightRecord : Form
    {
        public FlightRecord()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (FLCodeTB.Text == "" || SourceIn.Text == "" || SourceOut.Text == "" || FDate.Text == "" || PassengerSeatsTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into FlightTBL values('" + FLCodeTB.Text + "','" + SourceIn.SelectedItem.ToString() + "','" + SourceOut.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "'," + PassengerSeatsTB.Text + ")";
                    SqlCommand van = new SqlCommand(query, Conn);
                    van.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FLCodeTB.Text = "";
            PassengerSeatsTB.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home xd = new Home();
            xd.Show();
            this.Hide();
        }
    }
}

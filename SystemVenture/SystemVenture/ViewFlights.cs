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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");
        private void populate()
        {
            Conn.Open();
            string query = "Select * from FlightTBL";
            SqlDataAdapter sas = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sas);
            var ds = new DataSet();
            sas.Fill(ds);

            FlightViewDGV.DataSource = ds.Tables[0];

            Conn.Close();

        }
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FlightRecord fa1 = new FlightRecord();
            fa1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlightTB.Text = "";
            PassengerTB.Text = "";
        }

        private void FlightViewDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlightTB.Text = FlightViewDGV.SelectedRows[0].Cells[0].Value.ToString();
            SourceIn.SelectedItem = FlightViewDGV.SelectedRows[0].Cells[1].Value.ToString();
            SourceOut.SelectedItem = FlightViewDGV.SelectedRows[0].Cells[2].Value.ToString();
            PassengerTB.Text = FlightViewDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FlightTB.Text == "")
            {
                MessageBox.Show("Enter the Flight to delete");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from FlightTBL where Fcode='" + FlightTB.Text + "';";
                    SqlCommand cmdd = new SqlCommand(query, Conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Conn.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (FlightTB.Text == "" || PassengerTB.Text == "") {

                MessageBox.Show("Missing Information");

            } else
            {
                try
                {
                    Conn.Open();

                    string query = "update FlightTBL set Fsrc='" + SourceIn.SelectedItem.ToString() + "' ,FDest= '" + SourceOut.SelectedItem.ToString() + "', FDate='" + FDate2.Value.Date.ToString() + "' , Fcap='" + PassengerTB.Text + " where Fcode ='" + FlightTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");

                    Conn.Close();
                    populate();

                } catch(Exception ex) {
                    MessageBox.Show("Missing Information");

                }
                
            }
            {

            }
        }
    }
}

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
using System.Security.Cryptography;

namespace SystemVenture
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");
        private void fillPassenger()
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("select PassengerID from PassengerTBL", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassengerID", typeof(int));
            dt.Load(rdr);
            PidCb.ValueMember = "PassengerID";
            PidCb.DataSource = dt;

            Conn.Close();
        }
        private void fillFlightCode()
        {

            Conn.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTBL", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FcodeCb.ValueMember = "Fcode";
            FcodeCb.DataSource = dt;
            Conn.Close();

        }
        private void populate()
        {
            Conn.Open();

            string query = "select * from TicketTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];

            Conn.Close();
        }
        string pname, ppass, pnat;
        private void fetchpasser()
        {
            Conn.Open();

            string query = "select * from PassengerTBL where PassengerID=" + PidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassengerName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassengerNTL"].ToString();
                PnameTB.Text = pname;
                PPassTB.Text = ppass;
                PNatCb.Text = pnat;

            }
            Conn.Close();
        }
        private void Tickets_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
        }

        private void PidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpasser();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PnameTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();

                    string query = "insert into TicketTBL values(" + Tid.Text + ",'" + FcodeCb.SelectedValue.ToString() + "'," + PidCb.SelectedValue.ToString() + ",'" + PnameTB.Text + "','" + PPassTB.Text + "','" + PnameTB.Text + "'," + Pamt1.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Succeessfully");
                    Conn.Close();
                    populate();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnameTB.Text = "";
            PPassTB.Text = "";
            PNatCb.Text = "";
            Pamt1.Text = "";
            Tid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home xd = new Home();
            xd.Show();
            this.Hide();
        }
    }
}

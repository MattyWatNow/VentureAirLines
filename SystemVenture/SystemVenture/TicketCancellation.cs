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
using System.IO;
using System.Security.Cryptography;

namespace SystemVenture
{
    public partial class TicketCancellation : Form
    {
        public TicketCancellation()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-JI35400\SQLEXPRESS;Initial Catalog=AirLineVenture;Integrated Security=True;");
        private void fillTicketId()
        {

            Conn.Open();
            SqlCommand cmd = new SqlCommand("select Tid from TicketTBL", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;
            Conn.Close();

        }
        private void fetchfcode()
        {
            Conn.Open();

            string query = "select * from TicketTBL where Tid=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                FCancelCodeTB.Text = dr["Fcode"].ToString();

            }
            Conn.Close();
        }

        private void populate()
        {
            Conn.Open();
            string query = "Select * from CancelTBL";
            SqlDataAdapter sas = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sas);
            var ds = new DataSet();
            sas.Fill(ds);

            CancelDGV.DataSource = ds.Tables[0];

            Conn.Close();

        }

        private void TicketCancellation_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CancelTB.Text = "";
            FCancelCodeTB.Text = "";

        }
        private void deleteTicket()
        {
            try
            {
                Conn.Open();
                string query = "delete from TicketTBL where Tid=" + TidCb.SelectedValue.ToString() + ";";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (CancelTB.Text == "" || FCancelCodeTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();

                    string query = "insert into CancelTBL values(" + CancelTB.Text + "," + TidCb.SelectedValue.ToString() + ",'" + FCancelCodeTB.Text + "','" + FCancelDate1.Value.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Succeessfully");
                    Conn.Close();
                    populate();
                    deleteTicket();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home xd = new Home();
            xd.Show();
            this.Hide();
        }
    }
}
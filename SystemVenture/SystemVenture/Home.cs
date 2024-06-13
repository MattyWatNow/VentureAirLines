using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemVenture
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightRecord flight = new FlightRecord();
            flight.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassengerRecord pass = new PassengerRecord();
            pass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets booking = new Tickets();
            booking.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TicketCancellation cancell = new TicketCancellation();
            cancell.Show();
            this.Hide();
        }
    }
}

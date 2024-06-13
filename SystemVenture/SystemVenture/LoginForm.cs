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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearBot1_Click(object sender, EventArgs e)
        {
            UserBox.Text = "";
            UserPassBox.Text = "";
        }

        private void LogBot1_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "" || UserPassBox.Text == "")
            {
                MessageBox.Show("Enter the User Id and Password");
            }
            else if (UserBox.Text == "Admin" && UserPassBox.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password, Try again!");
            }
        }
    }
}

namespace SystemVenture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressB.Value = startpoint;
            if (ProgressB.Value == 100)
            {

                ProgressB.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

namespace AirPlanes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void GetStarted_Click(object sender, EventArgs e)
        {
            GetStarted p =new GetStarted();
            this.Hide();
            p.Show();
        }

        private void Hotels_Click(object sender, EventArgs e)
        {
            Hotels p1 = new Hotels();
            this.Hide();
            p1.Show();
        }

        private void Signin_Click(object sender, EventArgs e)
        {

        }
    }
}
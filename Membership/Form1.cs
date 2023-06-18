namespace Membership
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string password = Password.Text;
            if (user == "Admin" && password == "admin123")
            {
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
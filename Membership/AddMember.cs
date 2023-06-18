using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Membership
{
    public partial class AddMember : Form
    {
        private string gender;
        private string subscription;



        public AddMember()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MEMBERSHIP ", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            MemberID.Text = Convert.ToString(count++);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1900, 01, 01);
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            string Fname = FirstName.Text;
            String Mname = MiddleName.Text;
            string Lname = LastName.Text;
            string dateToday = dateTimePicker1.Text;
            DateTime dates = Convert.ToDateTime(dateToday);
            string MID = MemberID.Text;
            string endDate = "none";
            string gender = GEnderbox.Text;
            if (subscription.Equals("Standard")) { endDate = Convert.ToString(dates.AddDays(30)); }
            else if (subscription.Equals("Premium")) { endDate = Convert.ToString(dates.AddDays(60)); }

            string command = "insert into MEMBERSHIP values('" + MID + "', '" + Fname + "', '" + Mname + "', '" + Lname + "', '" + gender + "', '" + subscription + "', '" + dateToday + "', '" + endDate + "');";
            sql.sqlCommandqueryReader(command);
            MessageBox.Show("done");
            Main m = new Main();
            m.Show();
            this.Hide();
        }
        private void standard_Click(object sender, EventArgs e)
        {
            subscription = "Standard";
        }

        private void premium_Click(object sender, EventArgs e)
        {
            subscription = "Premium";
        }
        private void MemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void GEnderbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Membership
{
    public partial class Main : Form
    {
        bool sidebarExpand;
        public Main()
        {
            InitializeComponent();
            comboBox1.Items.Add("Standard");
            comboBox1.Items.Add("Premium");
        }
        DataSet ds = new DataSet();
        ///For animations
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }
        private void PMenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }
        ///end of animation method
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddMemButton_Click(object sender, EventArgs e)
        {
            AddMember Am = new AddMember();                                 ///meathod to show addmember form
            Am.Show();
            this.Hide();
        }
        /// <summary>
        /// for showing data base in the data grid
        /// 
        /// </summary>
        private void BindGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Membership", @"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            da.Fill(ds, "Membership");
            dataGridView1.DataSource = ds.Tables["Membership"].DefaultView;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Membership", @"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            da.Fill(ds, "Membership");
            dataGridView1.DataSource = ds.Tables["Membership"].DefaultView;
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MEMBERSHIP WHERE Membership_type='Standard';", con);
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM MEMBERSHIP WHERE Membership_type='Premium';", con);
            var count1 = cmd.ExecuteScalar();
            var count2 = cmd1.ExecuteScalar();
            normalcount.Text = count1.ToString();
            Premuimcount.Text = count2.ToString();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            SqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM MEMBERSHIP WHERE First_Name LIKE'" + this.SearchBox.Text + "%'OR Last_Name LIKE '" + this.SearchBox.Text + "%'OR Membership_ID LIKE '" + this.SearchBox.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            string search = SearchBox.Text;
            SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM MEMBERSHIP WHERE First_Name LIKE'" + search + "%'", @"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            Da.Equals(search);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string selID = dataGridView1.CurrentRow.Cells["Membership_ID"].Value.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            SqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new SqlDataAdapter("DELETE MEMBERSHIP WHERE Membership_ID = '" + selID + "'", con);
            MessageBox.Show("Deleted Successfully");
            SqlDataAdapter da1 = new SqlDataAdapter(" SELECT * FROM Membership ", con);
            con.Close();
            dt = new DataTable();
            da.Fill(dt);
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            SqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM MEMBERSHIP WHERE First_Name LIKE'" + this.SearchBox.Text + "%'OR Last_Name LIKE '" + this.SearchBox.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            SqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM MEMBERSHIP WHERE Membership_type LIKE'" + this.comboBox1.Text + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            SqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM MEMBERSHIP WHERE First_Name LIKE'" + this.SearchBox.Text + "%'OR Last_Name LIKE '" + this.SearchBox.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();
        }

        private void normalcount_Click(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

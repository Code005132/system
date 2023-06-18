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
namespace Membership
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Transgender");
            comboBox1.Items.Add("Gender neutral");
            comboBox1.Items.Add("Non-binary");
            comboBox1.Items.Add("Agender");
            comboBox1.Items.Add("Pangender");
            comboBox1.Items.Add("Genderqueer");
            comboBox1.Items.Add("Two-spirit penguin");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AddMemButton_Click(object sender, EventArgs e)
        {
            AddMember Am = new AddMember();
            Am.Show();
            this.Hide();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void update_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Membership", @"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");
            DataTable dt;
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                MemIDtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Membership_ID"].FormattedValue.ToString();
                Fnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells["First_Name"].FormattedValue.ToString();
                Mnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Middle_Name"].FormattedValue.ToString();
                Lnametextbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Last_Name"].FormattedValue.ToString();
                membertype.Text = dataGridView1.Rows[e.RowIndex].Cells["Membership_type"].FormattedValue.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();


            }
        }

        private void updatebtun_Click(object sender, EventArgs e)
        {
            string selID = dataGridView1.CurrentRow.Cells["Membership_ID"].Value.ToString();
            Sql sql = new Sql();
            string Fname = Fnametextbox.Text;
            String Mname = Mnametextbox.Text;
            string Lname = Lnametextbox.Text;
            string dateToday = dateTimePicker1.Text;
            string MID = MemIDtextbox.Text;
            string gender = comboBox1.Text;
            string memtype = membertype.Text;
            DateTime dates = Convert.ToDateTime(dateToday);
            string endDate = "none";
            if (memtype.Equals("Standard")) { endDate = Convert.ToString(dates.AddDays(30)); }
            else if (memtype.Equals("Premium")) { endDate = Convert.ToString(dates.AddDays(60)); }
            string command = "UPDATE MEMBERSHIP SET Membership_type='" + memtype + "', Date_Registered ='" + dateToday + "',Expiration_Date='" + endDate + "',Gender='" + gender + "' WHERE Membership_ID='" + selID + "'";
            sql.sqlCommandqueryReader(command);
            MessageBox.Show("Updated Successfully");
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1900, 01, 01);

        }

        private void membertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

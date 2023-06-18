using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Membership
{
    internal class Sql
    {
        SqlConnection con = new SqlConnection(@"Data Source=MANANGHAYA\MANANGHAYA;Initial Catalog=Membership;Integrated Security=True;");

        /*public DataTable dataAdapterSelect(string sqlQuery)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, con);
            DataTable tb = new DataTable();
            dataAdapter.Fill(tb);
            return tb;
        }*/

        public void sqlCommandqueryReader(String sqlQuery)
        {
            SqlCommand commands = new SqlCommand(sqlQuery, con);
            commands.Connection.Open();
            SqlDataReader dr;
            dr = commands.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);

            }
            commands.Connection.Close();
        }

    }
}

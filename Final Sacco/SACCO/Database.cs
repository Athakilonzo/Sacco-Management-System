using System.Data;
using System.Data.SqlClient;

namespace Final_Sacco.SACCO
{
    internal class Database
    {
        public static DataTable ReadFromDB(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            con.Close();
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }

        public static void CreateRecord(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
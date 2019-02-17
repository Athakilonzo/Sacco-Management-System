using System;
using System.Data.SqlClient;
using System.Data;


namespace Final_Sacco.SACCO
{
   public class Main
    {
        private SqlConnection connection;
        public static SqlConnection getconnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");
            return connection;
        }

        public string converter_string(string SQL)
        {
            try
            {
                SqlConnection con = Main.getconnection();
                DataTable consultantTable = new DataTable();
                string StringConsultant;
                SqlDataAdapter consultantAdapter = new SqlDataAdapter(SQL, con);
                consultantAdapter.Fill(consultantTable);
                
                foreach(DataRow myrow in consultantTable.Rows)
                {
                    StringConsultant = Convert.ToString(myrow[0]);
                    return StringConsultant;
                }
            }
            catch
            {
                throw;
            }
            return "0";
        }
        public void Execute(string SQL)
        {
            try
            {
                SqlConnection con = Main.getconnection();
                DataTable consultatntTable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(SQL, con);
                sda.Fill(consultatntTable);
            }
            catch
            {
                throw;
            }
        }
    }
}

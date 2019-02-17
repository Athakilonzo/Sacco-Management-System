using Final_Sacco.SACCO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco
{
    internal static class Program
    {
        public static string GetMemberIdNumber(string ID)
        {
            string sql = "SELECT MemberID FROM Members WHERE MemberID =@MemberID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("MemberID", ID);
            DataTable dt = Database.ReadFromDB(cmd);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }

        static public DataTable ListofMemberLoans(string IDNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MemberID, LoanAmount,Period FROM Loans WHERE MemberID=@MemberID AND Status = @Disbursed";
            cmd.Parameters.AddWithValue("MemberID", Program.GetMemberSystemID(IDNumber));
            cmd.Parameters.AddWithValue("Disbursed", Properties.Settings.Default.DisbursedLoanStatus);

            DataTable dt = Database.ReadFromDB(cmd);
            return dt;
        }




        public static string GetMemberName(string ID)
        {
            string sql = "SELECT MemberName FROM Members WHERE MemberID = @idnum";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("idnum", ID);
            DataTable dt = Database.ReadFromDB(cmd);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }
        /*amount to pay*/
        public static string GetAmountToPay(string ID)
        {
            string sql = "SELECT PaymentAmount,MemberID,Status FROM Loans WHERE MemberID=@idnum AND Status=@Disbursed";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("idnum", Program.GetMemberSystemID(ID));
            cmd.Parameters.AddWithValue("Disbursed", Properties.Settings.Default.DisbursedLoanStatus);
            DataTable dt = Database.ReadFromDB(cmd);
            
            if(dt.Rows.Count==1)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }
       

        public static string GetMemberSystemID(string IDNumber)
        {
            string sql = "SELECT MemberID FROM Members where MemberID = @idnum";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("idnum", IDNumber);
            DataTable dt = Database.ReadFromDB(cmd);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!System.IO.Directory.Exists(Application.StartupPath + "/passport"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "/passport");
            }

            /*  login frm = new login();
              DialogResult d = frm.ShowDialog();
              if (d == DialogResult.OK) */
            {
                Application.Run(new PayLoan());
            }
        }
    }
}
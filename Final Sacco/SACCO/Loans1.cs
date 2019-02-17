using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    internal class Loans1
    {
        static public DataTable ListofMemberLoans(string IDNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MemberID,LoanAmount,PaymentAmount FROM Loans WHERE MemberID=@ID AND Status = @Disbursed";
            cmd.Parameters.AddWithValue("ID", Program.GetMemberSystemID(IDNumber));
            
            cmd.Parameters.AddWithValue("Disbursed", Properties.Settings.Default.DisbursedLoanStatus);
            DataTable dt = Database.ReadFromDB(cmd);
            return dt;
        }


    
        public static double SimpleInterest(double Principal, double Rate, int time)
        {
            // P*R/100*T
            double body = (Rate / 100);

            return Principal * body * time;
        }

        static public bool ChangeLoanStatus(string LoanStatus, string LoanApplicationID)
        {
            try
            {
                string sql = "UPDATE Loans SET Status =@Status WHERE MemberID =@ID ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("Status", LoanStatus);
                cmd.Parameters.AddWithValue("ID", LoanApplicationID);
                Database.CreateRecord(cmd);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class applyloan : Form
    {
        public applyloan()
        {
            InitializeComponent();
        }

        private void txtidnumber_Leave(object sender, EventArgs e)
        {
            txtname.Text = Program.GetMemberName(Program.GetMemberSystemID(txtidnumber.Text));
        }

        private void btnSaveLoanApp_Click(object sender, EventArgs e)
        {
            if (Program.GetMemberSystemID(txtidnumber.Text) == "")
            {
                MessageBox.Show("Please provide a valid  Identification Number", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidnumber.Focus();
                return;
            }

            if (txtamount.Value < 1)
            {
                MessageBox.Show("The loan amount can not be zero or less than zero", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtamount.Focus();
                return;
            }

            //Process and Save Loan Details
            string sql = "Insert into Loans(MemberID,LoanAmount,Period,Status,ApplicationDate,ApprovalDate,DisburseDate,TotalInterest,PaymentAmount)" +
                "values(@MID,@LAmount,@Period,@Status,@ApplicationDate,@ApprovalDate,@DisburseDate,@TotalInterest,@Amount)";
            string status = Properties.Settings.Default.AppliedLoanStatus;
            string ApprovalDate = "", DisburseDate = "";

            if (chkapprove.Checked)
            {
                status = Properties.Settings.Default.ApprovedLoanStatus;
                ApprovalDate = txtdate.Value.ToString();
            }

            if (chkdisburse.Checked)
            {
                status = Properties.Settings.Default.DisbursedLoanStatus;
                ApprovalDate = txtdate.Value.ToString();
                DisburseDate = txtdate.Value.ToString();
            }

            //Calculate Interest & Repayable Amount

            int years = (int)(Convert.ToDecimal(txtperiod.Text) / 12);
            // int InstallationsPerYear = (int)txtinstallations.Value / years;
            double interest = Loans1.SimpleInterest((double)txtamount.Value, Properties.Settings.Default.interest, years);
            double TotalAmount = interest + (double)txtamount.Value;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("MID", Program.GetMemberSystemID(txtidnumber.Text));
            cmd.Parameters.AddWithValue("LAmount", txtamount.Value);
            cmd.Parameters.AddWithValue("Period", txtperiod.Text);

            cmd.Parameters.AddWithValue("Status", status);
            cmd.Parameters.AddWithValue("ApplicationDate", DateTime.Now);
            cmd.Parameters.AddWithValue("ApprovalDate", ApprovalDate);
            cmd.Parameters.AddWithValue("DisburseDate", DisburseDate);
            cmd.Parameters.AddWithValue("TotalInterest", interest);
            cmd.Parameters.AddWithValue("Amount", TotalAmount);

            txtamount.Value = 0;
            txtperiod.Text = "";

            Database.CreateRecord(cmd);
            MessageBox.Show("Sucess!", "ISUGURU SACCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
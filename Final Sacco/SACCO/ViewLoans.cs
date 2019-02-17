using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class ViewLoans : Form
    {
        public ViewLoans()
        {
            InitializeComponent();
            AllLoans.Checked = true;
            LoadLoans("");
        }

        private void newLoanApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLoans frm = new ViewLoans();

            DialogResult d = frm.ShowDialog();
            if (d == DialogResult.OK)
            {
                ReloadGridContent();
            }
        }

        private void ReloadGridContent()
        {
        }

        private void LoadLoans(string status = "1")
        {
            if (status == "1")
            {
                status = Properties.Settings.Default.AppliedLoanStatus;
            }

            string sql = "SELECT * FROM Loans WHERE Status like @Status";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Status", "%" + status + "%");
            cmd.CommandType = CommandType.Text;
            DataTable dt = Database.ReadFromDB(cmd);
            LoadLoanstoGrid(dt);
        }

        private void LoadLoanstoGrid(DataTable dt)
        {
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            grid.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r1 in dt.Rows)
                {
                    // string id = r1["id"].ToString();
                    string IDNumber = Program.GetMemberIdNumber(r1["MemberID"].ToString());
                    string MemberName = Program.GetMemberName(r1["MemberID"].ToString());
                    string Status = r1["Status"].ToString();
                    string AmountBorrowed = r1["LoanAmount"].ToString();
                    string Period = r1["Period"].ToString();

                    string InterestAccrued = r1["TotalInterest"].ToString();
                    string RepaymentAmount = r1["PaymentAmount"].ToString();
                    string DateDisbursed = r1["DisburseDate"].ToString();
                    string DateApplied = r1["ApplicationDate"].ToString();
                    string DateApproved = r1["ApprovalDate"].ToString();

                    grid.Rows.Add(
                           // id,
                           IDNumber,
                           MemberName,
                           Status,
                           AmountBorrowed,
                           Period,
                           InterestAccrued,
                           RepaymentAmount,
                           DateDisbursed,
                           DateApplied,
                           DateApproved
                           );
                }
            }
        }

        private void newLoanApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            applyloan frm = new applyloan();
            frm.Show();
        }

        private void approveSelectedLoanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    string LoanApplicationID = row.Cells["MemberID"].Value.ToString();
                    Loans1.ChangeLoanStatus(Properties.Settings.Default.ApprovedLoanStatus, LoanApplicationID);
                }

                ReloadGridContent();
                MessageBox.Show("Loan Status was updated Successfully", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void disburseSelectedLoanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    string LoanApplicationID = row.Cells["MemberID"].Value.ToString();
                    Loans1.ChangeLoanStatus(Properties.Settings.Default.DisbursedLoanStatus, LoanApplicationID);
                }

                ReloadGridContent();
                MessageBox.Show("The loan status of the selected loans was updated successfully", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loanRepaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loanpayment frm = new loanpayment();
            DialogResult d = frm.ShowDialog();
            if (d == DialogResult.OK)
            {
                //refresh
                ReloadGridContent();
            }
        }

        private void pendingApproval_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadLoans(Properties.Settings.Default.AppliedLoanStatus);
        }

        private void approvedRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadLoans(Properties.Settings.Default.ApprovedLoanStatus);
        }

        public void DisbursedRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadLoans(Properties.Settings.Default.DisbursedLoanStatus);

        }

        private void PaidRadio_CheckedChanged(object sender, EventArgs e)
        {
            LoadLoans(Properties.Settings.Default.PaidLoanStatus);
        }

        private void AllLoans_CheckedChanged(object sender, EventArgs e)
        {
            LoadLoans("");
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
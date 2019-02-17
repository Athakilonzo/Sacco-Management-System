using System;
using System.Data;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class loanpayment : Form
    {
        public loanpayment()
        {
            InitializeComponent();
        }

        private void txtidnumber_Leave_1(object sender, EventArgs e)
        {
            txtname.Text = Program.GetMemberName(Program.GetMemberSystemID(txtidnumber.Text));
           
        }


        private void cmdpay_Click(object sender, EventArgs e)
        {

            DataTable dt = Loans1.ListofMemberLoans(txtidnumber.Text);

            cboloans.Items.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string LoanDetails = row[2].ToString() + "-" + row[1].ToString();
                    cboloans.Items.Add(LoanDetails);
                }

                cmdpay.Enabled = true;
            }
            else
            {
                MessageBox.Show("This member does not have a loan due", "ISUGURU MIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidnumber.Focus();
                cmdpay.Enabled = false;
            }

            if (cboloans.Items.Count > 0)
            {
                cboloans.SelectedIndex = 0;
            }
        }

        private void cboloans_Leave(object sender, EventArgs e)
        {

        }

        private void chkclear_CheckedChanged(object sender, EventArgs e)
        {
            if(chkclear.Checked==true)
            {
               
            }
        }
    }
}
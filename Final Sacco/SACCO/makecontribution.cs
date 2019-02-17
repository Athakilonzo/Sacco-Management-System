using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class makecontribution : Form
    {
        public makecontribution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.GetMemberSystemID(txtidnumber.Text) == "")
            {
                MessageBox.Show("The identification number provided is not associated to any member.", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidnumber.Focus();
                return;
            }

            if (txtamount.Value < 1)
            {
                MessageBox.Show("Please enter the amount paid for this contribution", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtamount.Focus();
                return;
            }

            string sql = "insert into MemberContributions(MemberID,PaidFor,TransactionID, Amount, DatePaid, Note, Mode) values(@MemberID,@PaidFor,@TransactionID,@Amount,@DatePaid,@Note,@Mode)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("MemberID", Program.GetMemberSystemID(txtidnumber.Text));
            cmd.Parameters.AddWithValue("@PaidFor", txtCycle.Text);
            cmd.Parameters.AddWithValue("@TransactionID", txtamount.Value);
            cmd.Parameters.AddWithValue("@Amount", txttransid.Text);
            cmd.Parameters.AddWithValue("@DatePaid", DateTime.Now);
            cmd.Parameters.AddWithValue("@Note", txtnote.Text);
            cmd.Parameters.AddWithValue("@Mode", cbopaymentmode.Text);

            Database.CreateRecord(cmd);
            MessageBox.Show("Member contribution has been added successfully", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCycle.Text = "";
            cbopaymentmode.Text = "";
            txttransid.Text = "";
            txtnote.Text = "";
            txtamount.Value = 0;
            txtnote.Text = "";
        }

        private void makecontribution_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtidnumber_Leave(object sender, EventArgs e)
        {
            txtname.Text = Program.GetMemberName(Program.GetMemberSystemID(txtidnumber.Text));
        }
    }
}
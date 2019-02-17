using System;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class PayLoan : Form
    {
        public PayLoan()
        {
            InitializeComponent();
        }

        private void txtidnumber_Leave(object sender, EventArgs e)
        {
            txtname.Text = Program.GetMemberName(Program.GetMemberSystemID(txtidnumber.Text));
            TxtAmountToPay.Text = Program.GetAmountToPay(Program.GetMemberSystemID(txtidnumber.Text));
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {

           


            int amountToPay = Convert.ToInt32(TxtTest.Text);

        int amountPaid = Convert.ToInt32(TxtAmountPaid.Text);

        int balance = amountToPay - amountPaid;

        Txtbalance1.Text=Convert.ToString(balance);

        }
    }
}

using System;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class membersearch : Form
    {
        public string MemberIDNumber, MemberName, PhoneNumber;

        public membersearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberIDNumber = txtidnumber.Text;
            MemberName = txtname.Text;
            PhoneNumber = txtphonenumber.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class SysSettings : Form
    {
        public SysSettings()
        {
            InitializeComponent();
            txtinterest.Text = Properties.Settings.Default.interest.ToString();
            txtusername.Text = Properties.Settings.Default.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminpassword frm = new adminpassword();
            DialogResult d = frm.ShowDialog();

            if (d == DialogResult.OK)
            {
                Properties.Settings.Default.Interest = (float)Convert.ToDouble(txtinterest.Text);
                Properties.Settings.Default.Save();
                if (txtusername.Text != "" && txtpassword.Text != "")
                {
                    //change password
                    Properties.Settings.Default.Username = txtusername.Text;
                    Properties.Settings.Default.Password = txtpassword.Text;
                    Properties.Settings.Default.Save();
                }
                if (txtadmpassword.Text != "" && txtadmuser.Text != "")
                {
                    //change password
                    Properties.Settings.Default.AdminPassword = txtadmpassword.Text;
                    Properties.Settings.Default.AdminUsername = txtadmuser.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void txtinterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
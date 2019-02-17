using Final_Sacco.Reports;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Final_Sacco.UControls;
using System.Data.SqlClient;
using System.Data;

namespace Final_Sacco.SACCO
{
    public partial class Admin : Form
    {
        /*    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            ); */

        public Admin()
        {
            InitializeComponent();
            /*   this.FormBorderStyle = FormBorderStyle.None;
               Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); */

            //User Control section
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            //userControl11.BringToFront();
        }


        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Orange;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Orange;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            memberControl1.BringToFront();

            string action = "Member Button Invoked";
            Main code = new Main();
            code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(login.username) + "','" + login.MID + "','" + DateTime.Now + "','" + action + "','" + login.CIP + "')");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            loanControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            systemUserControl1.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    

        private void ContributeNavMenu_Click(object sender, EventArgs e)
        {
            makecontribution frm = new makecontribution();
            frm.ShowDialog();
        }

        private void EditMenuNavMember_Click(object sender, EventArgs e)
        {
            EditMember frm = new EditMember();
            frm.ShowDialog();
        }

        private void SearchMemberNavMenu_Click(object sender, EventArgs e)
        {
            membersearch frm = new membersearch();
            frm.ShowDialog();
        }

        private void ApplyLoanNavMenu_Click(object sender, EventArgs e)
        {
            applyloan frm = new applyloan();
            frm.ShowDialog();

            string action = "Loan Application Invoked";
            Main code = new Main();
            code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(login.username) + "','" + login.MID + "','" + DateTime.Now + "','" + action + "','" + login.CIP + "')");
        }

        private void LoanPaymentNavMenu_Click(object sender, EventArgs e)
        {
            loanpayment frm = new loanpayment();
            frm.ShowDialog();

            string action = "Loan Payment Invoked";
            Main code = new Main();
            code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(login.username) + "','" + login.MID + "','" + DateTime.Now + "','" + action + "','" + login.CIP + "')");
        }

        private void reportGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLoans rpt = new ViewLoans();
            rpt.ShowDialog();
        }

        private void ViewContributionsNavMenu_Click(object sender, EventArgs e)
        {
            Contributions frm = new Contributions();
            frm.ShowDialog();
        }

        private void gridReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersDataset frm = new MembersDataset();
            frm.ShowDialog();
        }

        private void fullReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemberReport frm = new MemberReport();
            frm.ShowDialog();
        }

        private void fullReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanReport frm = new LoanReport();
            frm.ShowDialog();
        }

        private void fullReportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ContributionReport frm = new ContributionReport();
            frm.ShowDialog();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.Show();


            string action = "Logged Out";
            Main code = new Main();
            code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(login.username) + "','" + login.MID + "','" + DateTime.Now + "','" + action + "','" + login.CIP + "')");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
        }

        private void memberControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
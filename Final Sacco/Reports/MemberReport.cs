using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.Reports
{
    public partial class MemberReport : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            RptMembers Report1 = new RptMembers();
            MembersDataset dsMembers = GetData();
            Report1.SetDataSource(dsMembers);
            this.crystalReportViewer1.ReportSource = Report1;
            this.crystalReportViewer1.RefreshReport();
        }

        private MembersDataset GetData()
        {
            string constr = @"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 20 * FROM Members"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (MembersDataset dsCustomers = new MembersDataset())
                        {
                            sda.Fill(dsCustomers, "Members");
                            return dsCustomers;
                        }
                    }
                }
            }
        }
    }
}
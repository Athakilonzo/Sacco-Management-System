using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.Reports
{
    public partial class ContributionReport : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

        public ContributionReport()
        {
            InitializeComponent();
        }

        private void ContributionReport_Load(object sender, EventArgs e)
        {
            RptContributions Report1 = new RptContributions();
            MembersDataset dsContr = GetData();
            Report1.SetDataSource(dsContr);
            this.crystalReportViewer1.ReportSource = Report1;
            this.crystalReportViewer1.RefreshReport();
        }

        private MembersDataset GetData()
        {
            string constr = @"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT top 20 * FROM MemberContributions"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (MembersDataset dsContr = new MembersDataset())
                        {
                            sda.Fill(dsContr, "MemberContributions");
                            return dsContr;
                        }
                    }
                }
            }
        }
    }
}
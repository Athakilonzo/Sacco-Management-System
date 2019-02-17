using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.Reports
{
    public partial class LoanReport : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

        public LoanReport()
        {
            InitializeComponent();
        }

        private void LoanReport_Load(object sender, EventArgs e)
        {
            RptLoans Report1 = new RptLoans();
            MembersDataset dsLoans = GetData();
            Report1.SetDataSource(dsLoans);
            this.crystalReportViewer1.ReportSource = Report1;
            this.crystalReportViewer1.RefreshReport();
        }

        private MembersDataset GetData()
        {
            string constr = @"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 20 * FROM Loans"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (MembersDataset dsLoans1 = new MembersDataset())
                        {
                            sda.Fill(dsLoans1, "Loans");
                            return dsLoans1;
                        }
                    }
                }
            }
        }
    }
}
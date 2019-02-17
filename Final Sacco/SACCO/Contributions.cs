using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class Contributions : Form
    {
        public Contributions(string IDNumber = "")
        {
            InitializeComponent();

            if (IDNumber != "")
            {
                txtidnumber.Text = IDNumber;
                btnlookup.PerformClick();
            }
            else
            {
                LoadAll();
            }
        }

        private void LoadAll()
        {
            string sql = "SELECT * FROM MemberContributions";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            DataTable dt = Database.ReadFromDB(cmd);
            loadtoGrid(dt);
        }

        private void LoadSpecificMember(string IDumber)
        {
            try
            {
                string sql = "SELECT * FROM MemberContributions";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                DataTable dt = Database.ReadFromDB(cmd);
                loadtoGrid(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void loadtoGrid(DataTable dt)
        {
            grid.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                int rowID = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    grid.Rows.Add(

                        dr["MemberID"].ToString(),
                        Program.GetMemberName(dr["MemberID"].ToString()),
                        dr["TransactionID"].ToString(),
                        dr["PaidFor"].ToString(),
                        dr["Amount"].ToString(),
                        dr["Mode"].ToString(),
                        dr["DatePaid"].ToString(),
                        dr["Note"].ToString()
                        );
                    grid.Rows[rowID].HeaderCell.Value = (rowID + 1).ToString();
                    rowID++;
                }
            }
        }

        private void btnlookup_Click_1(object sender, EventArgs e)
        {
            LoadSpecificMember(txtidnumber.Text);
        }

        private void addContributionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contributions frm = new Contributions();
            DialogResult d = frm.ShowDialog();
            if (d == DialogResult.OK)
            {
                LoadAll();
            }
        }
    }
}
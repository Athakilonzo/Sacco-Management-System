using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class MembersDataset : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

        public MembersDataset()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void loadMembers2Grid(DataTable dt)
        {
            grid.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Bitmap bt;

                    if (dr["profileimage"].ToString() != "")
                    {
                        //bt = new Bitmap(Application.StartupPath + "/passports/" + dr["Passport"].ToString());
                        using (System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + "/passport/" + dr["Profileimage"].ToString(), System.IO.FileMode.Open))
                        {
                            bt = new Bitmap(fs);
                        }
                    }
                    else
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + "/default.jpg", System.IO.FileMode.Open))
                        {
                            bt = new Bitmap(fs);
                        }
                    }

                    grid.Rows.Add(
                            dr["MemberID"].ToString(),
                            dr["MemberName"].ToString(),
                            //  dr["ID_Num"].ToString(),
                            dr["PhoneNumber"].ToString(),
                            dr["TotalShares"].ToString(),

                            dr["RAddress"].ToString(),
                            dr["RegistrationDate"].ToString()
                        );
                }
            }
        }

        /*   private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
           {
               if(grid.SelectedRows.Count > 0)
               {
                   DialogResult d = MessageBox.Show("Are you sure you want to delete selected Members?", "SACCO MIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if(d==DialogResult.Yes)
                   {
                       foreach(DataGridView row in grid.SelectedRows)
                       {
                           SqlCommand cmd = new SqlCommand();
                           cmd.CommandText = "DELETE * FROM Members WHERE ID=@del";
                           cmd.Parameters.AddWithValue("del",row.Cells["MemberID"].Value);
                           cmd.CommandType = CommandType.Text;
                           Database.CreateRecord(cmd);
                       }
                       MessageBox.Show("Deleted Successfully", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       LoadMembers();
                   }
               }
           } */

        private void SearchMembers(string name, string idnum, string phone, string sql = "select * from Members WHERE MemberName LIKE @name AND MemberID LIKE @id AND PhoneNumber LIKE @phone")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("name", "%" + name + "%");
            cmd.Parameters.AddWithValue("id", "%" + idnum + "%");
            cmd.Parameters.AddWithValue("phone", "%" + phone + "%");
            DataTable dt = Database.ReadFromDB(cmd);

            loadMembers2Grid(dt);
        }

        private void LoadMembers(string sql = "SELECT * FROM Members")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            DataTable dt = Database.ReadFromDB(cmd);

            loadMembers2Grid(dt);
        }

        private void closeFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewMemberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addmember frm = new addmember();
            DialogResult d = frm.ShowDialog();
            if (d == DialogResult.OK)
            {
                //refresh grid
                LoadMembers();
            }
        }

        private void editSelectedMemberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                string MemberID = grid.SelectedCells[0].Value.ToString();
                EditMember frm = new EditMember(MemberID);
                DialogResult d = frm.ShowDialog();
                if (d == DialogResult.OK)
                {
                    LoadMembers();
                }
            }
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            membersearch frm = new membersearch();
            DialogResult d = new DialogResult();
            if (d == DialogResult.OK)
            {
                SearchMembers(frm.MemberName, frm.MemberIDNumber, frm.PhoneNumber);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete selected members?", "Wakulima Sacco MIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                foreach (DataGridView row in grid.SelectedRows)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE * FROM Members WHERE MemberID=@del";
                    // cmd.Parameters.AddWithValue("del",row.cells["MemberID"].Value);
                    cmd.CommandType = CommandType.Text;
                    Database.CreateRecord(cmd);
                }
                MessageBox.Show("Members have been deleted successfully", "Wakulima Sacco MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
            }
        }
    }
}

/*   private void printToolStripMenuItem_Click(object sender, EventArgs e)
   {
       reports_dataset itemsLbl = new reports_dataset(); //dataset whose the crystal report gets data from
       DataTable dataTable = itemsLbl.Members;  //data table containing real data
       rptmembers Report = new rptmembers();

       int x = 0;
       foreach (DataGridViewRow row in grid.Rows)
       {
           x++;

           DataRow drow = dataTable.NewRow();

           drow["ID"] = row.Cells[0].Value;
           drow["Name"] = row.Cells[1].Value;
           drow["IDNumber"] = row.Cells[2].Value;
           drow["PhoneNumber"] = row.Cells[3].Value;
           drow["TotalShares"] = row.Cells[4].Value;
           drow["Date"] = row.Cells[6].Value;

           dataTable.Rows.Add(drow);
       }

       Report.Database.Tables["Members"].SetDataSource((DataTable)dataTable);
       frmshowreports frm = new frmshowreports(Report, "Members Report");
       frm.ShowDialog();
   }
} */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class EditMember : Form
    {
        private string Member_ID = "";

        public EditMember(string ID)
        {
            Member_ID = ID;
            InitializeComponent();
            LoadMember();
        }

        public EditMember()
        {
        }

        private void LoadMember(string sql = "select * from Members where MemberID =@MemberID")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("MemberID", Member_ID);
            DataTable dt = Database.ReadFromDB(cmd);

            if (dt.Rows.Count == 1)
            {
                txtmembername.Text = dt.Rows[0]["MemberName"].ToString();
                txtidnumber.Text = dt.Rows[0]["MemberID"].ToString();
                txtshares.Text = dt.Rows[0]["TotalShares"].ToString();
                txtphonenumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                txtpostaladdress.Text = dt.Rows[0]["RAddress"].ToString();
            }
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtmembername.Text == "")
            {
                MessageBox.Show("The member name is required", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmembername.Focus();
                return;
            }

            if (txtidnumber.Text == "")
            {
                MessageBox.Show("The member identification number is required", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtidnumber.Focus();
                return;
            }

            string sql = "UPDATE Members SET MemberName = @name,MemberID=@id,PhoneNumber=@phone,TotalShares=@shares, RAddress=@postal WHERE MemberID=@mid";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("name", txtmembername.Text);
            cmd.Parameters.AddWithValue("id", txtidnumber.Text);
            cmd.Parameters.AddWithValue("phone", txtphonenumber.Text);
            cmd.Parameters.AddWithValue("shares", txtshares.Text);
            cmd.Parameters.AddWithValue("postal", txtpostaladdress.Text);
            cmd.Parameters.AddWithValue("mid", Member_ID);
            Database.CreateRecord(cmd);
            this.DialogResult = DialogResult.OK;
        }
    }
}
    

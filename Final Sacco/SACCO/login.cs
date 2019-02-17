using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class login : Form
    {
        public static string CIP = "";
        public static string MID = "1";
        public static string username = "1";
        


        SqlConnection connection = Main.getconnection();
        //   SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
            label3.Text = CIP;
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            Application.Exit();
        }

        public void cmdlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Username Cannot be Blank", "ISUGURU MIS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Password Cannot be Blank", "ISUGURU MIS", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            try
            {
                Main code = new Main();
                string login = "Logged In";

                string sqlEmpNo = "SELECT MemberID FROM Admin WHERE username='" + Convert.ToString(txtusername.Text) + "' AND password='" + Convert.ToString(txtpassword.Text) + "'";
                MID = code.converter_string(sqlEmpNo).ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE username=@username AND password=@password", connection);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                connection.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(txtusername.Text) + "','" +MID + "','" + DateTime.Now + "','" + login + "','" + CIP + "')");

                    MessageBox.Show("Login Successful!", "ISGURU MIS");
                    this.Hide();
                    Admin frm = new Admin();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed", "ISUGURU MIS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            getIP();
        }
    }
}


   






    /*   else
            {
                string Admin = "Admin";
                Main code = new Main();
                string sqlEmpNo = "SELECT MemberID FROM Admin WHERE username='" + Convert.ToString(txtusername.Text) + "' AND password='" + Convert.ToString(txtpassword.Text) + "'";
                MID = code.converter_string(sqlEmpNo).ToString();

                if (MID=="")
                {
                    string sqlLoginName = "SELECT username from Admin WHERE MemberID='" + Convert.ToString(MID) + "'";
                    username = code.converter_string(sqlLoginName).ToString();





                    code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(txtusername.Text) + "','" + MID + "','" + DateTime.Now + "','" + Admin + "','" + CIP + "')");


                    Admin frmmain = new Admin();
                    frmmain.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    frmmain.Show();
                }
                else
                {
                    MessageBox.Show("invalid password");
                }
            } */



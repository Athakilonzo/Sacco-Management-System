using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Final_Sacco.SACCO
{
    public partial class addmember : Form
    {
        public addmember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmembername.Text == "")
            {
                MessageBox.Show("Member Name is required", "Sacco MIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmembername.Focus();
                return;
            }
            if (txtidnumber.Text == "")
            {
                MessageBox.Show("Member ID is required", "Sacco MIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtidnumber.Focus();
                return;
            }

            //save file
            var SavedFileName = string.Format(@"{0}.png", Guid.NewGuid());
            var path = Application.StartupPath + "/passport/" + SavedFileName.ToString();

            if (passportsize.Image == null)
            {
                SavedFileName = "";
            }
            else
            {
                passportsize.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V5221FL\SQLEXPRESS;Initial Catalog=SACCO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Members (MemberID,MemberName,PhoneNumber,TotalShares,RAddress,Profileimage,RegistrationDate) Values( @MemberID,@MemberName,@PhoneNumber,@TotalShares,@RAddress,@Profileimage,GETDATE())", con);
            cmd.Parameters.AddWithValue("MemberID", txtidnumber.Text);
            cmd.Parameters.AddWithValue("MemberName", txtmembername.Text);
            cmd.Parameters.AddWithValue("PhoneNumber", txtphonenumber.Text);
            cmd.Parameters.AddWithValue("TotalShares", txtshares.Text);
            cmd.Parameters.AddWithValue("RAddress", txtpostaladdress.Text);
            cmd.Parameters.AddWithValue("Profileimage", SavedFileName);
            cmd.Parameters.AddWithValue("RegistrationDate", DateTime.Now);

            Database.CreateRecord(cmd);
            this.DialogResult = DialogResult.OK;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture Files | *.bmp;*.jpg;*.gif;*.png;*.jpeg";
            ofd.Title = "Sacco MIS | Select Profile Photo";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                passportsize.Image = new Bitmap(fs);
            }
        }
    }
}
using Final_Sacco.SACCO;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Final_Sacco.UControls
{
    public partial class MemberControl : UserControl
    {
        public MemberControl()
        {
            InitializeComponent();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
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
                passportsize.Image.Save(path, ImageFormat.Png);
            }

            //Save Signature
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.InitialDirectory = @"C:";
            savefile.Title = "Save Signature";
            savefile.AddExtension = true;
            savefile.DefaultExt = "bmp";
            savefile.FilterIndex = 2;
            savefile.RestoreDirectory = true;

            if(DigitalSignatureBox.Image==null)
            {
                return;
            }

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string fName = savefile.FileName;
                DigitalSignatureBox.Image.Save(fName, ImageFormat.Bmp);
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
            MessageBox.Show("Member Registration Successful", "SACCO MIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtidnumber.Text = "";
            txtmembername.Text = "";
            txtphonenumber.Text = "";
            txtshares.Text = "";
            txtpostaladdress.Text = "";



            string action = "New Member Added";
            Main code = new Main();
            code.Execute(@"INSERT INTO ActivityLog VALUES('" + Convert.ToString(login.username) + "','" + login.MID + "','" + DateTime.Now + "','" + action + "','" + login.CIP + "')");
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

        private void BtnDigitalSignature_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string lokasi = file.InitialDirectory;
            lokasi = @"C:";
            file.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.png;*.jpeg;*.tiff";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                DigitalSignatureBox.Image = new Bitmap(file.FileName);
            }
        }
    }
}
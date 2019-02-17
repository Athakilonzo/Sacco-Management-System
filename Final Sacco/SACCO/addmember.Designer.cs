namespace Final_Sacco.SACCO
{
    partial class addmember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtpostaladdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passportsize = new System.Windows.Forms.PictureBox();
            this.txtshares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passportsize)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save Member";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(18, 300);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(178, 45);
            this.btnPhoto.TabIndex = 24;
            this.btnPhoto.Text = "Select Passport Size Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // txtpostaladdress
            // 
            this.txtpostaladdress.Location = new System.Drawing.Point(212, 263);
            this.txtpostaladdress.Multiline = true;
            this.txtpostaladdress.Name = "txtpostaladdress";
            this.txtpostaladdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtpostaladdress.Size = new System.Drawing.Size(270, 82);
            this.txtpostaladdress.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Postal Address";
            // 
            // passportsize
            // 
            this.passportsize.BackColor = System.Drawing.Color.Black;
            this.passportsize.Location = new System.Drawing.Point(18, 86);
            this.passportsize.Name = "passportsize";
            this.passportsize.Size = new System.Drawing.Size(178, 208);
            this.passportsize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passportsize.TabIndex = 21;
            this.passportsize.TabStop = false;
            // 
            // txtshares
            // 
            this.txtshares.Location = new System.Drawing.Point(212, 211);
            this.txtshares.Name = "txtshares";
            this.txtshares.Size = new System.Drawing.Size(270, 20);
            this.txtshares.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Shares";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(212, 161);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(270, 20);
            this.txtphonenumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mobile Phone Number";
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(212, 110);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(270, 20);
            this.txtidnumber.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Member ID";
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(18, 54);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(464, 20);
            this.txtmembername.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member Name";
            // 
            // addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.txtpostaladdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passportsize);
            this.Controls.Add(this.txtshares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmembername);
            this.Controls.Add(this.label1);
            this.Name = "addmember";
            this.Text = "New Membership";
            ((System.ComponentModel.ISupportInitialize)(this.passportsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtpostaladdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox passportsize;
        private System.Windows.Forms.TextBox txtshares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.Label label1;
    }
}
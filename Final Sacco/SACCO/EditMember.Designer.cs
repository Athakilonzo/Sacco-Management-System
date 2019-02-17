namespace Final_Sacco.SACCO
{
    partial class EditMember
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
            this.txtpostaladdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtshares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 36;
            this.button2.Text = "Save Member";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtpostaladdress
            // 
            this.txtpostaladdress.Location = new System.Drawing.Point(14, 243);
            this.txtpostaladdress.Multiline = true;
            this.txtpostaladdress.Name = "txtpostaladdress";
            this.txtpostaladdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtpostaladdress.Size = new System.Drawing.Size(320, 64);
            this.txtpostaladdress.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Postal Address";
            // 
            // txtshares
            // 
            this.txtshares.Location = new System.Drawing.Point(14, 191);
            this.txtshares.Name = "txtshares";
            this.txtshares.Size = new System.Drawing.Size(320, 20);
            this.txtshares.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Total Shares";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(14, 141);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(320, 20);
            this.txtphonenumber.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mobile Phone Number";
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(14, 90);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(320, 20);
            this.txtidnumber.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "National ID Number";
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(12, 37);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(322, 20);
            this.txtmembername.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member Name";
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpostaladdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtshares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmembername);
            this.Controls.Add(this.label1);
            this.Name = "EditMember";
            this.Text = "EditMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtpostaladdress;
        private System.Windows.Forms.Label label5;
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
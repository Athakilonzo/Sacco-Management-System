namespace Final_Sacco.SACCO
{
    partial class PayLoan
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.Txtbalance1 = new System.Windows.Forms.TextBox();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            this.TxtAmountToPay = new System.Windows.Forms.TextBox();
            this.TxtTest = new System.Windows.Forms.TextBox();
            this.TxtAmountPaid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 96);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(332, 20);
            this.txtname.TabIndex = 21;
            // 
            // Txtbalance1
            // 
            this.Txtbalance1.Location = new System.Drawing.Point(12, 262);
            this.Txtbalance1.Name = "Txtbalance1";
            this.Txtbalance1.ReadOnly = true;
            this.Txtbalance1.Size = new System.Drawing.Size(332, 20);
            this.Txtbalance1.TabIndex = 22;
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(12, 47);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(332, 20);
            this.txtidnumber.TabIndex = 25;
            this.txtidnumber.Leave += new System.EventHandler(this.txtidnumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Amount To Pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Amount Paid";
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPay.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPay.Location = new System.Drawing.Point(115, 288);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(156, 36);
            this.BtnPay.TabIndex = 31;
            this.BtnPay.Text = "Make Payment";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // TxtAmountToPay
            // 
            this.TxtAmountToPay.Location = new System.Drawing.Point(12, 153);
            this.TxtAmountToPay.Name = "TxtAmountToPay";
            this.TxtAmountToPay.ReadOnly = true;
            this.TxtAmountToPay.Size = new System.Drawing.Size(332, 20);
            this.TxtAmountToPay.TabIndex = 32;
            // 
            // TxtTest
            // 
            this.TxtTest.Location = new System.Drawing.Point(135, 338);
            this.TxtTest.Name = "TxtTest";
            this.TxtTest.Size = new System.Drawing.Size(155, 20);
            this.TxtTest.TabIndex = 33;
            // 
            // TxtAmountPaid
            // 
            this.TxtAmountPaid.Location = new System.Drawing.Point(12, 223);
            this.TxtAmountPaid.Name = "TxtAmountPaid";
            this.TxtAmountPaid.Size = new System.Drawing.Size(326, 20);
            this.TxtAmountPaid.TabIndex = 34;
            // 
            // PayLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 370);
            this.Controls.Add(this.TxtAmountPaid);
            this.Controls.Add(this.TxtTest);
            this.Controls.Add(this.TxtAmountToPay);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.Txtbalance1);
            this.Controls.Add(this.txtname);
            this.Name = "PayLoan";
            this.Text = "PayLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox Txtbalance1;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.TextBox TxtAmountToPay;
        private System.Windows.Forms.TextBox TxtTest;
        private System.Windows.Forms.TextBox TxtAmountPaid;
    }
}
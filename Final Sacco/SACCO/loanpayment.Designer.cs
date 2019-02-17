namespace Final_Sacco.SACCO
{
    partial class loanpayment
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
            this.txtloanbalance = new System.Windows.Forms.TextBox();
            this.cmdpay = new System.Windows.Forms.Button();
            this.chkclear = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.cboloans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtloanbalance
            // 
            this.txtloanbalance.Location = new System.Drawing.Point(23, 226);
            this.txtloanbalance.Name = "txtloanbalance";
            this.txtloanbalance.ReadOnly = true;
            this.txtloanbalance.Size = new System.Drawing.Size(258, 20);
            this.txtloanbalance.TabIndex = 24;
            this.txtloanbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdpay
            // 
            this.cmdpay.Location = new System.Drawing.Point(23, 255);
            this.cmdpay.Name = "cmdpay";
            this.cmdpay.Size = new System.Drawing.Size(258, 49);
            this.cmdpay.TabIndex = 23;
            this.cmdpay.Text = "Make Payment";
            this.cmdpay.UseVisualStyleBackColor = true;
            this.cmdpay.Click += new System.EventHandler(this.cmdpay_Click);
            // 
            // chkclear
            // 
            this.chkclear.AutoSize = true;
            this.chkclear.Location = new System.Drawing.Point(79, 160);
            this.chkclear.Name = "chkclear";
            this.chkclear.Size = new System.Drawing.Size(77, 17);
            this.chkclear.TabIndex = 22;
            this.chkclear.Text = "Clear Loan";
            this.chkclear.UseVisualStyleBackColor = true;
            this.chkclear.CheckedChanged += new System.EventHandler(this.chkclear_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(20, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Remaining Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.DecimalPlaces = 2;
            this.txtamount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtamount.Location = new System.Drawing.Point(23, 181);
            this.txtamount.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(258, 20);
            this.txtamount.TabIndex = 19;
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtamount.ThousandsSeparator = true;
            // 
            // cboloans
            // 
            this.cboloans.FormattingEnabled = true;
            this.cboloans.Location = new System.Drawing.Point(23, 130);
            this.cboloans.Name = "cboloans";
            this.cboloans.Size = new System.Drawing.Size(258, 21);
            this.cboloans.TabIndex = 18;
            this.cboloans.Leave += new System.EventHandler(this.cboloans_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Loan";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(23, 84);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(258, 20);
            this.txtname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(23, 37);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(258, 20);
            this.txtidnumber.TabIndex = 14;
            this.txtidnumber.Leave += new System.EventHandler(this.txtidnumber_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "National ID Number";
            // 
            // loanpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 328);
            this.Controls.Add(this.txtloanbalance);
            this.Controls.Add(this.cmdpay);
            this.Controls.Add(this.chkclear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.cboloans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.label1);
            this.Name = "loanpayment";
            this.Text = "Loan Re-Payment";
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtloanbalance;
        private System.Windows.Forms.Button cmdpay;
        private System.Windows.Forms.CheckBox chkclear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.ComboBox cboloans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label1;
    }
}
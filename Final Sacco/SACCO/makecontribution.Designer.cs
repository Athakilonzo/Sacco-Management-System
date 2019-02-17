namespace Final_Sacco.SACCO
{
    partial class makecontribution
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txttransid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbopaymentmode = new System.Windows.Forms.ComboBox();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save Contributions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(22, 85);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(349, 20);
            this.txtname.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Member Name";
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(6, 290);
            this.txtnote.MaxLength = 200;
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnote.Size = new System.Drawing.Size(337, 61);
            this.txtnote.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Remarks";
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "MM/dd/yyyy";
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(6, 241);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(337, 20);
            this.txtdate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Paid";
            // 
            // txttransid
            // 
            this.txttransid.Location = new System.Drawing.Point(6, 195);
            this.txttransid.Name = "txttransid";
            this.txttransid.Size = new System.Drawing.Size(337, 20);
            this.txttransid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reference/Cheque/Transaction Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment Mode";
            // 
            // cbopaymentmode
            // 
            this.cbopaymentmode.FormattingEnabled = true;
            this.cbopaymentmode.Items.AddRange(new object[] {
            "Bank Deposit",
            "Cash",
            "Cheque",
            "Mpesa",
            "Airtel Money",
            "Orange Money",
            "YuCash",
            "Others",
            ""});
            this.cbopaymentmode.Location = new System.Drawing.Point(6, 142);
            this.cbopaymentmode.Name = "cbopaymentmode";
            this.cbopaymentmode.Size = new System.Drawing.Size(337, 21);
            this.cbopaymentmode.TabIndex = 5;
            // 
            // txtCycle
            // 
            this.txtCycle.Location = new System.Drawing.Point(6, 90);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(337, 20);
            this.txtCycle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paid For";
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
            this.txtamount.Location = new System.Drawing.Point(6, 39);
            this.txtamount.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(337, 20);
            this.txtamount.TabIndex = 3;
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtamount.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount Paid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnote);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttransid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbopaymentmode);
            this.groupBox1.Controls.Add(this.txtCycle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contribution Details";
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(20, 39);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(349, 20);
            this.txtidnumber.TabIndex = 11;
            this.txtidnumber.TextChanged += new System.EventHandler(this.txtidnumber_Leave);
            this.txtidnumber.Leave += new System.EventHandler(this.txtidnumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "National ID Number";
            // 
            // makecontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.label1);
            this.Name = "makecontribution";
            this.Text = "Make Contribution";
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttransid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbopaymentmode;
        private System.Windows.Forms.TextBox txtCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label1;
    }
}
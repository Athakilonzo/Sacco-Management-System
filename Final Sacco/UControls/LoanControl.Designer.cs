namespace Final_Sacco.UControls
{
    partial class LoanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkdisburse = new System.Windows.Forms.CheckBox();
            this.chkapprove = new System.Windows.Forms.CheckBox();
            this.BtnSaveApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(15, 46);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(351, 20);
            this.txtidnumber.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Member Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(17, 92);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(349, 20);
            this.txtname.TabIndex = 20;
            
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Member ID";
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(6, 206);
            this.txtnote.MaxLength = 200;
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnote.Size = new System.Drawing.Size(337, 61);
            this.txtnote.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remarks";
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "MM/dd/yyyy";
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(6, 154);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(337, 20);
            this.txtdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Application Date";
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(6, 92);
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(337, 20);
            this.txtperiod.TabIndex = 4;
            this.txtperiod.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loan Period (Months)";
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
            this.txtamount.Location = new System.Drawing.Point(6, 41);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Loan Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtperiod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(449, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 289);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Details";
            // 
            // chkdisburse
            // 
            this.chkdisburse.AutoSize = true;
            this.chkdisburse.Location = new System.Drawing.Point(148, 170);
            this.chkdisburse.Name = "chkdisburse";
            this.chkdisburse.Size = new System.Drawing.Size(131, 17);
            this.chkdisburse.TabIndex = 25;
            this.chkdisburse.Text = "Approve and Disburse";
            this.chkdisburse.UseVisualStyleBackColor = true;
            // 
            // chkapprove
            // 
            this.chkapprove.AutoSize = true;
            this.chkapprove.Location = new System.Drawing.Point(69, 170);
            this.chkapprove.Name = "chkapprove";
            this.chkapprove.Size = new System.Drawing.Size(66, 17);
            this.chkapprove.TabIndex = 24;
            this.chkapprove.Text = "Approve";
            this.chkapprove.UseVisualStyleBackColor = true;
            // 
            // BtnSaveApplication
            // 
            this.BtnSaveApplication.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSaveApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveApplication.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveApplication.Location = new System.Drawing.Point(80, 233);
            this.BtnSaveApplication.Name = "BtnSaveApplication";
            this.BtnSaveApplication.Size = new System.Drawing.Size(150, 50);
            this.BtnSaveApplication.TabIndex = 23;
            this.BtnSaveApplication.Text = "Save Application";
            this.BtnSaveApplication.UseVisualStyleBackColor = false;
            this.BtnSaveApplication.Click += new System.EventHandler(this.BtnSaveApplication_Click);
            // 
            // LoanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSaveApplication);
            this.Controls.Add(this.chkdisburse);
            this.Controls.Add(this.chkapprove);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Name = "LoanControl";
            this.Size = new System.Drawing.Size(859, 388);
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkdisburse;
        private System.Windows.Forms.CheckBox chkapprove;
        private System.Windows.Forms.Button BtnSaveApplication;
    }
}

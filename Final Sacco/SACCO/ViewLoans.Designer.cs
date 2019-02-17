namespace Final_Sacco.SACCO
{
    partial class ViewLoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.loanRepaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disburseSelectedLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveSelectedLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLoanApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllLoans = new System.Windows.Forms.RadioButton();
            this.PaidRadio = new System.Windows.Forms.RadioButton();
            this.DisbursedRadio = new System.Windows.Forms.RadioButton();
            this.approvedRadio = new System.Windows.Forms.RadioButton();
            this.pendingApproval = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisburseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.Lavender;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.Status,
            this.LoanAmount,
            this.Period,
            this.TotalInterest,
            this.PaymentAmount,
            this.DisburseDate,
            this.ApplicationDate,
            this.ApprovalDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 95);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(800, 355);
            this.grid.TabIndex = 5;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // loanRepaymentToolStripMenuItem
            // 
            this.loanRepaymentToolStripMenuItem.Name = "loanRepaymentToolStripMenuItem";
            this.loanRepaymentToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.loanRepaymentToolStripMenuItem.Text = "Pay Loan";
            this.loanRepaymentToolStripMenuItem.Click += new System.EventHandler(this.loanRepaymentToolStripMenuItem_Click_1);
            // 
            // disburseSelectedLoanToolStripMenuItem
            // 
            this.disburseSelectedLoanToolStripMenuItem.Name = "disburseSelectedLoanToolStripMenuItem";
            this.disburseSelectedLoanToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.disburseSelectedLoanToolStripMenuItem.Text = "Disburse Selected Loan";
            this.disburseSelectedLoanToolStripMenuItem.Click += new System.EventHandler(this.disburseSelectedLoanToolStripMenuItem_Click_1);
            // 
            // approveSelectedLoanToolStripMenuItem
            // 
            this.approveSelectedLoanToolStripMenuItem.Name = "approveSelectedLoanToolStripMenuItem";
            this.approveSelectedLoanToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.approveSelectedLoanToolStripMenuItem.Text = "Approve Loan";
            this.approveSelectedLoanToolStripMenuItem.Click += new System.EventHandler(this.approveSelectedLoanToolStripMenuItem_Click_1);
            // 
            // newLoanApplicationToolStripMenuItem
            // 
            this.newLoanApplicationToolStripMenuItem.Name = "newLoanApplicationToolStripMenuItem";
            this.newLoanApplicationToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.newLoanApplicationToolStripMenuItem.Text = "New Application";
            this.newLoanApplicationToolStripMenuItem.Click += new System.EventHandler(this.newLoanApplicationToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLoanApplicationToolStripMenuItem,
            this.approveSelectedLoanToolStripMenuItem,
            this.disburseSelectedLoanToolStripMenuItem,
            this.loanRepaymentToolStripMenuItem,
            this.printResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 71);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // printResultsToolStripMenuItem
            // 
            this.printResultsToolStripMenuItem.Name = "printResultsToolStripMenuItem";
            this.printResultsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.printResultsToolStripMenuItem.Text = "Print Results";
            // 
            // AllLoans
            // 
            this.AllLoans.AutoSize = true;
            this.AllLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllLoans.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLoans.ForeColor = System.Drawing.Color.Blue;
            this.AllLoans.Location = new System.Drawing.Point(421, 21);
            this.AllLoans.Name = "AllLoans";
            this.AllLoans.Size = new System.Drawing.Size(38, 20);
            this.AllLoans.TabIndex = 4;
            this.AllLoans.TabStop = true;
            this.AllLoans.Text = "All";
            this.AllLoans.UseVisualStyleBackColor = true;
            this.AllLoans.CheckedChanged += new System.EventHandler(this.AllLoans_CheckedChanged);
            // 
            // PaidRadio
            // 
            this.PaidRadio.AutoSize = true;
            this.PaidRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaidRadio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PaidRadio.Location = new System.Drawing.Point(324, 21);
            this.PaidRadio.Name = "PaidRadio";
            this.PaidRadio.Size = new System.Drawing.Size(84, 20);
            this.PaidRadio.TabIndex = 3;
            this.PaidRadio.TabStop = true;
            this.PaidRadio.Text = "Paid Loans";
            this.PaidRadio.UseVisualStyleBackColor = true;
            this.PaidRadio.CheckedChanged += new System.EventHandler(this.PaidRadio_CheckedChanged);
            // 
            // DisbursedRadio
            // 
            this.DisbursedRadio.AutoSize = true;
            this.DisbursedRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisbursedRadio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisbursedRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DisbursedRadio.Location = new System.Drawing.Point(234, 21);
            this.DisbursedRadio.Name = "DisbursedRadio";
            this.DisbursedRadio.Size = new System.Drawing.Size(79, 20);
            this.DisbursedRadio.TabIndex = 2;
            this.DisbursedRadio.TabStop = true;
            this.DisbursedRadio.Text = "Disbursed";
            this.DisbursedRadio.UseVisualStyleBackColor = true;
            this.DisbursedRadio.CheckedChanged += new System.EventHandler(this.DisbursedRadio_CheckedChanged_1);
            // 
            // approvedRadio
            // 
            this.approvedRadio.AutoSize = true;
            this.approvedRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approvedRadio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.approvedRadio.Location = new System.Drawing.Point(149, 21);
            this.approvedRadio.Name = "approvedRadio";
            this.approvedRadio.Size = new System.Drawing.Size(76, 20);
            this.approvedRadio.TabIndex = 1;
            this.approvedRadio.TabStop = true;
            this.approvedRadio.Text = "Approved";
            this.approvedRadio.UseVisualStyleBackColor = true;
            this.approvedRadio.CheckedChanged += new System.EventHandler(this.approvedRadio_CheckedChanged_1);
            // 
            // pendingApproval
            // 
            this.pendingApproval.AutoSize = true;
            this.pendingApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingApproval.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingApproval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pendingApproval.Location = new System.Drawing.Point(18, 21);
            this.pendingApproval.Name = "pendingApproval";
            this.pendingApproval.Size = new System.Drawing.Size(119, 20);
            this.pendingApproval.TabIndex = 0;
            this.pendingApproval.TabStop = true;
            this.pendingApproval.Text = "Pending Approval";
            this.pendingApproval.UseVisualStyleBackColor = true;
            this.pendingApproval.CheckedChanged += new System.EventHandler(this.pendingApproval_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllLoans);
            this.groupBox1.Controls.Add(this.PaidRadio);
            this.groupBox1.Controls.Add(this.DisbursedRadio);
            this.groupBox1.Controls.Add(this.approvedRadio);
            this.groupBox1.Controls.Add(this.pendingApproval);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Loans Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 3;
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "Loan Amount";
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.ReadOnly = true;
            // 
            // Period
            // 
            this.Period.HeaderText = "Period";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // TotalInterest
            // 
            this.TotalInterest.HeaderText = "Total Interest";
            this.TotalInterest.Name = "TotalInterest";
            this.TotalInterest.ReadOnly = true;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.HeaderText = "Payment Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            // 
            // DisburseDate
            // 
            this.DisburseDate.HeaderText = "Disburse Date";
            this.DisburseDate.Name = "DisburseDate";
            this.DisburseDate.ReadOnly = true;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            // 
            // ApprovalDate
            // 
            this.ApprovalDate.HeaderText = "Approval Date";
            this.ApprovalDate.Name = "ApprovalDate";
            this.ApprovalDate.ReadOnly = true;
            // 
            // ViewLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewLoans";
            this.Text = "ViewLoans";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolStripMenuItem loanRepaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disburseSelectedLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveSelectedLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLoanApplicationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printResultsToolStripMenuItem;
        private System.Windows.Forms.RadioButton AllLoans;
        private System.Windows.Forms.RadioButton PaidRadio;
        private System.Windows.Forms.RadioButton DisbursedRadio;
        private System.Windows.Forms.RadioButton approvedRadio;
        private System.Windows.Forms.RadioButton pendingApproval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisburseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalDate;
    }
}
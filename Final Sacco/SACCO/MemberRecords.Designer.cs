namespace Final_Sacco.SACCO
{
    partial class MemberRecords
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
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(112, 271);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(94, 38);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "First";
            this.BtnFirst.UseVisualStyleBackColor = true;
            
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(212, 271);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(94, 38);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(312, 271);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(94, 38);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(412, 271);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(94, 38);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = "BtnLast";
            this.BtnLast.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(115, 217);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(91, 20);
            this.TxtId.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 14;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(452, 217);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(162, 20);
            this.TxtName.TabIndex = 15;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // MemberRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnFirst);
            this.Name = "MemberRecords";
            this.Text = "MemberRecords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
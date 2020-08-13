namespace Borrow
{
    partial class Frm_Report
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
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(165, 203);
            this.txtHead.Name = "txtHead";
            this.txtHead.ReadOnly = true;
            this.txtHead.Size = new System.Drawing.Size(100, 22);
            this.txtHead.TabIndex = 6;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(165, 150);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(165, 95);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(165, 46);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 9;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(95, 203);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(41, 12);
            this.lblHead.TabIndex = 2;
            this.lblHead.Text = "頭期款";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(95, 150);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(46, 12);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "利率(%)";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(95, 95);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 12);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "期限(年)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(95, 46);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 12);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "借貸金額";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Location = new System.Drawing.Point(97, 260);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(41, 12);
            this.lblTotalPay.TabIndex = 10;
            this.lblTotalPay.Text = "總付款";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // Frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAmount);
            this.Name = "Frm_Report";
            this.Text = "Frm_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.TextBox textBox1;
    }
}
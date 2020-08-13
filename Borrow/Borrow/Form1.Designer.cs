namespace Borrow
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(90, 34);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 12);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "借貸金額";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(90, 83);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 12);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "期限(年)";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(90, 138);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(46, 12);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "利率(%)";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(90, 191);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(41, 12);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "頭期款";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(160, 34);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(160, 83);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 1;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(160, 138);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 1;
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(160, 191);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(100, 22);
            this.txtHead.TabIndex = 1;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(184, 311);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = "PMT(月付)";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(326, 311);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(482, 311);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}


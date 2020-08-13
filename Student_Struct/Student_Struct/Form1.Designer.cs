namespace Student_Struct
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblChi = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtMaxMin = new System.Windows.Forms.TextBox();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.gbGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(42, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";
            // 
            // lblChi
            // 
            this.lblChi.AutoSize = true;
            this.lblChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChi.Location = new System.Drawing.Point(42, 82);
            this.lblChi.Name = "lblChi";
            this.lblChi.Size = new System.Drawing.Size(57, 25);
            this.lblChi.TabIndex = 1;
            this.lblChi.Text = "國文:";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEng.Location = new System.Drawing.Point(42, 132);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(57, 25);
            this.lblEng.TabIndex = 2;
            this.lblEng.Text = "英文:";
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMath.Location = new System.Drawing.Point(42, 183);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(57, 25);
            this.lblMath.TabIndex = 3;
            this.lblMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(122, 82);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(155, 25);
            this.txtChi.TabIndex = 5;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(122, 132);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(155, 25);
            this.txtEng.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(122, 183);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(155, 25);
            this.txtMath.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存內容";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(212, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 53);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "顯示內容";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.txtMaxMin);
            this.gbGrade.Controls.Add(this.txtGrade);
            this.gbGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbGrade.Location = new System.Drawing.Point(458, 12);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(330, 348);
            this.gbGrade.TabIndex = 9;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "成績";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.Control;
            this.txtGrade.Location = new System.Drawing.Point(17, 33);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(293, 191);
            this.txtGrade.TabIndex = 0;
            // 
            // txtMaxMin
            // 
            this.txtMaxMin.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaxMin.Location = new System.Drawing.Point(17, 239);
            this.txtMaxMin.Multiline = true;
            this.txtMaxMin.Name = "txtMaxMin";
            this.txtMaxMin.Size = new System.Drawing.Size(293, 90);
            this.txtMaxMin.TabIndex = 1;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(475, 382);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(293, 46);
            this.btnMaxMin.TabIndex = 10;
            this.btnMaxMin.Text = "最高分 / 最低分科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.gbGrade);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.lblChi);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGrade.ResumeLayout(false);
            this.gbGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChi;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbGrade;
        private System.Windows.Forms.TextBox txtMaxMin;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnMaxMin;
    }
}


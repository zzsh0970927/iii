namespace ForDoWhile
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnOodEven = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnArrOddEven = new System.Windows.Forms.Button();
            this.btnLongestName = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnCorc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOutside1Inside0 = new System.Windows.Forms.Button();
            this.btnOutside0Inside1 = new System.Windows.Forms.Button();
            this.btn101010010101 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnArrSum = new System.Windows.Forms.Button();
            this.btnArrMax = new System.Windows.Forms.Button();
            this.btnArrMin = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.btnRows = new System.Windows.Forms.Button();
            this.btn9x9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(9, 7);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 12);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(56, 5);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(76, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // btnOodEven
            // 
            this.btnOodEven.Location = new System.Drawing.Point(9, 40);
            this.btnOodEven.Margin = new System.Windows.Forms.Padding(2);
            this.btnOodEven.Name = "btnOodEven";
            this.btnOodEven.Size = new System.Drawing.Size(82, 36);
            this.btnOodEven.TabIndex = 2;
            this.btnOodEven.Text = "輸入的是奇數or偶數?";
            this.btnOodEven.UseVisualStyleBackColor = true;
            this.btnOodEven.Click += new System.EventHandler(this.btnOodEven_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(17, 273);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 21);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblAns.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAns.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAns.Location = new System.Drawing.Point(21, 305);
            this.lblAns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(42, 21);
            this.lblAns.TabIndex = 4;
            this.lblAns.Text = "結果";
            // 
            // btnArrOddEven
            // 
            this.btnArrOddEven.Location = new System.Drawing.Point(148, 7);
            this.btnArrOddEven.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrOddEven.Name = "btnArrOddEven";
            this.btnArrOddEven.Size = new System.Drawing.Size(135, 18);
            this.btnArrOddEven.TabIndex = 5;
            this.btnArrOddEven.Text = "陣列arr0711[]統計奇偶數";
            this.btnArrOddEven.UseVisualStyleBackColor = true;
            this.btnArrOddEven.Click += new System.EventHandler(this.btnArrOddEven_Click);
            // 
            // btnLongestName
            // 
            this.btnLongestName.Location = new System.Drawing.Point(148, 40);
            this.btnLongestName.Margin = new System.Windows.Forms.Padding(2);
            this.btnLongestName.Name = "btnLongestName";
            this.btnLongestName.Size = new System.Drawing.Size(148, 19);
            this.btnLongestName.TabIndex = 6;
            this.btnLongestName.Text = "陣列arr0711_Str[]最長的名子";
            this.btnLongestName.UseVisualStyleBackColor = true;
            this.btnLongestName.Click += new System.EventHandler(this.btnLongestName_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(9, 80);
            this.btnMaxMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(145, 26);
            this.btnMaxMin.TabIndex = 7;
            this.btnMaxMin.Text = "陣列arr0711[]最大最小值";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnCorc
            // 
            this.btnCorc.Location = new System.Drawing.Point(9, 110);
            this.btnCorc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCorc.Name = "btnCorc";
            this.btnCorc.Size = new System.Drawing.Size(220, 22);
            this.btnCorc.TabIndex = 8;
            this.btnCorc.Text = "陣列arr0711_Str[]xue\"C\"或\"c\"的字樣有幾個";
            this.btnCorc.UseVisualStyleBackColor = true;
            this.btnCorc.Click += new System.EventHandler(this.btnCorc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 49);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOutside1Inside0
            // 
            this.btnOutside1Inside0.Location = new System.Drawing.Point(324, 3);
            this.btnOutside1Inside0.Name = "btnOutside1Inside0";
            this.btnOutside1Inside0.Size = new System.Drawing.Size(144, 22);
            this.btnOutside1Inside0.TabIndex = 10;
            this.btnOutside1Inside0.Text = "[10,10]二維陣列-邊1內0";
            this.btnOutside1Inside0.UseVisualStyleBackColor = true;
            // 
            // btnOutside0Inside1
            // 
            this.btnOutside0Inside1.Location = new System.Drawing.Point(324, 37);
            this.btnOutside0Inside1.Name = "btnOutside0Inside1";
            this.btnOutside0Inside1.Size = new System.Drawing.Size(144, 22);
            this.btnOutside0Inside1.TabIndex = 11;
            this.btnOutside0Inside1.Text = "[10,10]二維陣列-邊0內1";
            this.btnOutside0Inside1.UseVisualStyleBackColor = true;
            // 
            // btn101010010101
            // 
            this.btn101010010101.Location = new System.Drawing.Point(324, 65);
            this.btn101010010101.Name = "btn101010010101";
            this.btn101010010101.Size = new System.Drawing.Size(98, 73);
            this.btn101010010101.TabIndex = 12;
            this.btn101010010101.Text = "[10,10]二維陣列        101010        010101";
            this.btn101010010101.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(491, 4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(117, 21);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "Swap[ int , int ]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnArrSum
            // 
            this.btnArrSum.Location = new System.Drawing.Point(491, 47);
            this.btnArrSum.Name = "btnArrSum";
            this.btnArrSum.Size = new System.Drawing.Size(117, 22);
            this.btnArrSum.TabIndex = 14;
            this.btnArrSum.Text = "Sum(陣列arr0711[])";
            this.btnArrSum.UseVisualStyleBackColor = true;
            this.btnArrSum.Click += new System.EventHandler(this.btnArrSum_Click);
            // 
            // btnArrMax
            // 
            this.btnArrMax.Location = new System.Drawing.Point(491, 80);
            this.btnArrMax.Name = "btnArrMax";
            this.btnArrMax.Size = new System.Drawing.Size(117, 22);
            this.btnArrMax.TabIndex = 15;
            this.btnArrMax.Text = "Max(陣列arr0711[])";
            this.btnArrMax.UseVisualStyleBackColor = true;
            this.btnArrMax.Click += new System.EventHandler(this.btnArrMax_Click);
            // 
            // btnArrMin
            // 
            this.btnArrMin.Location = new System.Drawing.Point(491, 116);
            this.btnArrMin.Name = "btnArrMin";
            this.btnArrMin.Size = new System.Drawing.Size(117, 22);
            this.btnArrMin.TabIndex = 15;
            this.btnArrMin.Text = "Min(陣列arr0711[])";
            this.btnArrMin.UseVisualStyleBackColor = true;
            this.btnArrMin.Click += new System.EventHandler(this.btnArrMin_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(201, 167);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 12);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(201, 194);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 12);
            this.lblTo.TabIndex = 16;
            this.lblTo.Text = "To:";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(201, 222);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(28, 12);
            this.lblStep.TabIndex = 16;
            this.lblStep.Text = "Step:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(241, 163);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(58, 22);
            this.txtFrom.TabIndex = 17;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(241, 191);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(58, 22);
            this.txtTo.TabIndex = 17;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(241, 219);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(58, 22);
            this.txtStep.TabIndex = 17;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Gold;
            this.btnFor.Location = new System.Drawing.Point(324, 160);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(56, 24);
            this.btnFor.TabIndex = 18;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.Gold;
            this.btnWhile.Location = new System.Drawing.Point(324, 188);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(56, 24);
            this.btnWhile.TabIndex = 18;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.Gold;
            this.btnDo.Location = new System.Drawing.Point(324, 216);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(56, 24);
            this.btnDo.TabIndex = 18;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = false;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(411, 163);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 12);
            this.lblRows.TabIndex = 19;
            this.lblRows.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(451, 157);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(43, 22);
            this.txtRows.TabIndex = 20;
            // 
            // btnRows
            // 
            this.btnRows.BackColor = System.Drawing.Color.Gold;
            this.btnRows.Location = new System.Drawing.Point(413, 188);
            this.btnRows.Name = "btnRows";
            this.btnRows.Size = new System.Drawing.Size(81, 23);
            this.btnRows.TabIndex = 21;
            this.btnRows.Text = "直角聖誕樹";
            this.btnRows.UseVisualStyleBackColor = false;
            // 
            // btn9x9
            // 
            this.btn9x9.BackColor = System.Drawing.Color.Gold;
            this.btn9x9.Location = new System.Drawing.Point(413, 219);
            this.btn9x9.Name = "btn9x9";
            this.btn9x9.Size = new System.Drawing.Size(81, 22);
            this.btn9x9.TabIndex = 22;
            this.btn9x9.Text = "九九乘法表";
            this.btn9x9.UseVisualStyleBackColor = false;
            this.btn9x9.Click += new System.EventHandler(this.btn9x9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 427);
            this.Controls.Add(this.btn9x9);
            this.Controls.Add(this.btnRows);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnArrMin);
            this.Controls.Add(this.btnArrMax);
            this.Controls.Add(this.btnArrSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn101010010101);
            this.Controls.Add(this.btnOutside0Inside1);
            this.Controls.Add(this.btnOutside1Inside0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCorc);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnLongestName);
            this.Controls.Add(this.btnArrOddEven);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOodEven);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnOodEven;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnArrOddEven;
        private System.Windows.Forms.Button btnLongestName;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnCorc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOutside1Inside0;
        private System.Windows.Forms.Button btnOutside0Inside1;
        private System.Windows.Forms.Button btn101010010101;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnArrSum;
        private System.Windows.Forms.Button btnArrMax;
        private System.Windows.Forms.Button btnArrMin;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button btnRows;
        private System.Windows.Forms.Button btn9x9;
    }
}


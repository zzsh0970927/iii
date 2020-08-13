namespace Hello
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
            this.lblEName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblConstellation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(124, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Location = new System.Drawing.Point(124, 159);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(91, 15);
            this.lblEName.TabIndex = 1;
            this.lblEName.Text = "English Name:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(124, 233);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 15);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性別:";
            // 
            // lblConstellation
            // 
            this.lblConstellation.AutoSize = true;
            this.lblConstellation.Location = new System.Drawing.Point(124, 298);
            this.lblConstellation.Name = "lblConstellation";
            this.lblConstellation.Size = new System.Drawing.Size(41, 15);
            this.lblConstellation.TabIndex = 3;
            this.lblConstellation.Text = "星座:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(243, 149);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(100, 25);
            this.txtEName.TabIndex = 5;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(243, 223);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 25);
            this.txtSex.TabIndex = 6;
            // 
            // txtConstellation
            // 
            this.txtConstellation.Location = new System.Drawing.Point(243, 288);
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(100, 25);
            this.txtConstellation.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(243, 366);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(106, 43);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(427, 365);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(110, 44);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtConstellation);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblConstellation);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblEName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "你好 C#!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblConstellation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtConstellation;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}


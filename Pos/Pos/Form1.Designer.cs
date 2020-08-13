namespace Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhiskey = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.總金額_TotalPrice = new System.Windows.Forms.ListBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.付款方式 = new System.Windows.Forms.ListBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.購物清單 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(14, 49);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(118, 81);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "      Beer          40元  ";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.White;
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Location = new System.Drawing.Point(152, 49);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(114, 81);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "Tequila   870元";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhiskey
            // 
            this.btnWhiskey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhiskey.BackgroundImage")));
            this.btnWhiskey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhiskey.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhiskey.Location = new System.Drawing.Point(14, 155);
            this.btnWhiskey.Name = "btnWhiskey";
            this.btnWhiskey.Size = new System.Drawing.Size(118, 82);
            this.btnWhiskey.TabIndex = 2;
            this.btnWhiskey.Text = "Whiskey   500元";
            this.btnWhiskey.UseVisualStyleBackColor = true;
            this.btnWhiskey.Click += new System.EventHandler(this.btnWhiskey_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(152, 155);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(114, 82);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "Wine     1000元";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMenu.Location = new System.Drawing.Point(10, 11);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(46, 21);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "菜單:";
            // 
            // 總金額_TotalPrice
            // 
            this.總金額_TotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.總金額_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.總金額_TotalPrice.FormattingEnabled = true;
            this.總金額_TotalPrice.ItemHeight = 21;
            this.總金額_TotalPrice.Location = new System.Drawing.Point(312, 49);
            this.總金額_TotalPrice.Name = "總金額_TotalPrice";
            this.總金額_TotalPrice.Size = new System.Drawing.Size(193, 88);
            this.總金額_TotalPrice.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.Location = new System.Drawing.Point(340, 88);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(140, 29);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // 付款方式
            // 
            this.付款方式.BackColor = System.Drawing.SystemColors.Control;
            this.付款方式.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.付款方式.FormattingEnabled = true;
            this.付款方式.ItemHeight = 21;
            this.付款方式.Location = new System.Drawing.Point(312, 149);
            this.付款方式.Name = "付款方式";
            this.付款方式.Size = new System.Drawing.Size(193, 88);
            this.付款方式.TabIndex = 8;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(327, 177);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(73, 33);
            this.btnCash.TabIndex = 9;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCredit.Location = new System.Drawing.Point(419, 177);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 33);
            this.btnCredit.TabIndex = 10;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // 購物清單
            // 
            this.購物清單.BackColor = System.Drawing.SystemColors.Control;
            this.購物清單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.購物清單.FormattingEnabled = true;
            this.購物清單.ItemHeight = 21;
            this.購物清單.Location = new System.Drawing.Point(548, 49);
            this.購物清單.Name = "購物清單";
            this.購物清單.Size = new System.Drawing.Size(240, 193);
            this.購物清單.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(691, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(308, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "總金額 Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(308, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "付款方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(544, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "購物清單";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(419, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 21);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信用卡享九折!";
            // 
            // txtList
            // 
            this.txtList.Enabled = false;
            this.txtList.Location = new System.Drawing.Point(565, 73);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(201, 126);
            this.txtList.TabIndex = 20;
            this.txtList.Text = "尚未點餐";
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.購物清單);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.付款方式);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.總金額_TotalPrice);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnWhiskey);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnBeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhiskey;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListBox 總金額_TotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ListBox 付款方式;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.ListBox 購物清單;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtList;
    }
}


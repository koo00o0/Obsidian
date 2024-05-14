namespace test
{
    partial class CafeMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuListBox = new System.Windows.Forms.ListBox();
            this.MenuPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SumMoney = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.MoneySum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕", 28F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(418, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE";
            // 
            // menuListBox
            // 
            this.menuListBox.Font = new System.Drawing.Font("굴림", 11F);
            this.menuListBox.FormattingEnabled = true;
            this.menuListBox.ItemHeight = 18;
            this.menuListBox.Location = new System.Drawing.Point(33, 318);
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(711, 184);
            this.menuListBox.TabIndex = 1;
            // 
            // MenuPayment
            // 
            this.MenuPayment.Location = new System.Drawing.Point(774, 451);
            this.MenuPayment.Name = "MenuPayment";
            this.MenuPayment.Size = new System.Drawing.Size(147, 51);
            this.MenuPayment.TabIndex = 2;
            this.MenuPayment.Text = "결제";
            this.MenuPayment.UseVisualStyleBackColor = true;
            this.MenuPayment.Click += new System.EventHandler(this.MenuPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "장바구니 금액 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "할인 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "총 결제 금액 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(774, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // SumMoney
            // 
            this.SumMoney.AutoSize = true;
            this.SumMoney.Location = new System.Drawing.Point(894, 318);
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Size = new System.Drawing.Size(37, 15);
            this.SumMoney.TabIndex = 3;
            this.SumMoney.Text = "금액";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(836, 356);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(37, 15);
            this.discount.TabIndex = 3;
            this.discount.Text = "할인";
            // 
            // MoneySum
            // 
            this.MoneySum.AutoSize = true;
            this.MoneySum.Location = new System.Drawing.Point(884, 412);
            this.MoneySum.Name = "MoneySum";
            this.MoneySum.Size = new System.Drawing.Size(62, 15);
            this.MoneySum.TabIndex = 3;
            this.MoneySum.Text = "총 금액 ";
            // 
            // CafeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoneySum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuPayment);
            this.Controls.Add(this.menuListBox);
            this.Controls.Add(this.label1);
            this.Name = "CafeMenu";
            this.Text = "CafeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox menuListBox;
        private System.Windows.Forms.Button MenuPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SumMoney;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label MoneySum;
    }
}
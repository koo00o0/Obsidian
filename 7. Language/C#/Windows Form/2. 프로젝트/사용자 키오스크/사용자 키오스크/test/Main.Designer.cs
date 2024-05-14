namespace test
{
    partial class Main
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
            this.UIdsession = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.Button();
            this.Pack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.HighlowB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIdsession
            // 
            this.UIdsession.AutoSize = true;
            this.UIdsession.Font = new System.Drawing.Font("굴림", 15F);
            this.UIdsession.Location = new System.Drawing.Point(25, 62);
            this.UIdsession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UIdsession.Name = "UIdsession";
            this.UIdsession.Size = new System.Drawing.Size(87, 25);
            this.UIdsession.TabIndex = 3;
            this.UIdsession.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "회원 화면";
            // 
            // Store
            // 
            this.Store.Location = new System.Drawing.Point(56, 202);
            this.Store.Margin = new System.Windows.Forms.Padding(2);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(162, 49);
            this.Store.TabIndex = 5;
            this.Store.Text = "매장";
            this.Store.UseVisualStyleBackColor = true;
            this.Store.Click += new System.EventHandler(this.Store_Click);
            // 
            // Pack
            // 
            this.Pack.Location = new System.Drawing.Point(354, 202);
            this.Pack.Margin = new System.Windows.Forms.Padding(2);
            this.Pack.Name = "Pack";
            this.Pack.Size = new System.Drawing.Size(162, 49);
            this.Pack.TabIndex = 6;
            this.Pack.Text = "포장";
            this.Pack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(349, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "금액 : ";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("굴림", 15F);
            this.Money.Location = new System.Drawing.Point(439, 62);
            this.Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(62, 25);
            this.Money.TabIndex = 3;
            this.Money.Text = "금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(349, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "등급 : ";
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Font = new System.Drawing.Font("굴림", 15F);
            this.Rank.Location = new System.Drawing.Point(439, 107);
            this.Rank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(62, 25);
            this.Rank.TabIndex = 3;
            this.Rank.Text = "등급";
            // 
            // HighlowB
            // 
            this.HighlowB.Location = new System.Drawing.Point(201, 302);
            this.HighlowB.Name = "HighlowB";
            this.HighlowB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HighlowB.Size = new System.Drawing.Size(154, 67);
            this.HighlowB.TabIndex = 7;
            this.HighlowB.Text = "하이로우 게임";
            this.HighlowB.UseVisualStyleBackColor = true;
            this.HighlowB.Click += new System.EventHandler(this.HighlowB_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 395);
            this.Controls.Add(this.HighlowB);
            this.Controls.Add(this.Pack);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UIdsession);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UIdsession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Store;
        private System.Windows.Forms.Button Pack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Button HighlowB;
    }
}
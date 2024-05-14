namespace test
{
    partial class Highlow
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
            this.NumInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userM = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.moneyB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumInput
            // 
            this.NumInput.Font = new System.Drawing.Font("굴림", 20F);
            this.NumInput.Location = new System.Drawing.Point(401, 228);
            this.NumInput.Name = "NumInput";
            this.NumInput.Size = new System.Drawing.Size(148, 46);
            this.NumInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "환영 문구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "판돈";
            // 
            // userM
            // 
            this.userM.AutoSize = true;
            this.userM.Font = new System.Drawing.Font("굴림", 14F);
            this.userM.Location = new System.Drawing.Point(104, 106);
            this.userM.Name = "userM";
            this.userM.Size = new System.Drawing.Size(114, 24);
            this.userM.TabIndex = 2;
            this.userM.Text = "유저 금액";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(32, 228);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(100, 25);
            this.MoneyBox.TabIndex = 3;
            // 
            // moneyB
            // 
            this.moneyB.Location = new System.Drawing.Point(159, 187);
            this.moneyB.Name = "moneyB";
            this.moneyB.Size = new System.Drawing.Size(94, 66);
            this.moneyB.TabIndex = 4;
            this.moneyB.Text = "판돈 입력";
            this.moneyB.UseVisualStyleBackColor = true;
            this.moneyB.Click += new System.EventHandler(this.moneyB_Click);
            // 
            // Highlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyB);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.userM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumInput);
            this.Name = "Highlow";
            this.Text = "Highlow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NumInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userM;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Button moneyB;
    }
}
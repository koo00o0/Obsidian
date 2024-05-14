namespace WindowsFormsApp3
{
    partial class PasswardFindPage
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
            this.userId = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.passwardF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(217, 161);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(308, 25);
            this.userId.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(217, 247);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(308, 25);
            this.userName.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "뒤로가기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // passwardF
            // 
            this.passwardF.Location = new System.Drawing.Point(241, 315);
            this.passwardF.Name = "passwardF";
            this.passwardF.Size = new System.Drawing.Size(261, 114);
            this.passwardF.TabIndex = 1;
            this.passwardF.Text = "비밀번호 찾기";
            this.passwardF.UseVisualStyleBackColor = true;
            this.passwardF.Click += new System.EventHandler(this.passwardF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(124, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(124, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // PasswardFindPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwardF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userId);
            this.Name = "PasswardFindPage";
            this.Text = "PasswardFindPage";
            this.Load += new System.EventHandler(this.PasswardFindPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button passwardF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
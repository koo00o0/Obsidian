using System;

namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userId = new System.Windows.Forms.TextBox();
            this.userPw = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.idCheck = new System.Windows.Forms.Button();
            this.userJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginFormN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userId
            // 
            this.userId.BackColor = System.Drawing.SystemColors.Control;
            this.userId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(156, 214);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(276, 21);
            this.userId.TabIndex = 0;
            // 
            // userPw
            // 
            this.userPw.BackColor = System.Drawing.SystemColors.Control;
            this.userPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPw.Location = new System.Drawing.Point(156, 301);
            this.userPw.Name = "userPw";
            this.userPw.Size = new System.Drawing.Size(276, 18);
            this.userPw.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Control;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Location = new System.Drawing.Point(161, 392);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(276, 18);
            this.userName.TabIndex = 0;
            // 
            // idCheck
            // 
            this.idCheck.BackColor = System.Drawing.Color.SkyBlue;
            this.idCheck.FlatAppearance.BorderSize = 0;
            this.idCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.idCheck.Location = new System.Drawing.Point(478, 188);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(102, 47);
            this.idCheck.TabIndex = 1;
            this.idCheck.Text = "Idcheck";
            this.idCheck.UseVisualStyleBackColor = false;
            this.idCheck.Click += new System.EventHandler(this.idCheck_Click);
            // 
            // userJoin
            // 
            this.userJoin.BackColor = System.Drawing.Color.SkyBlue;
            this.userJoin.FlatAppearance.BorderSize = 0;
            this.userJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userJoin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userJoin.Location = new System.Drawing.Point(480, 359);
            this.userJoin.Name = "userJoin";
            this.userJoin.Size = new System.Drawing.Size(106, 51);
            this.userJoin.TabIndex = 1;
            this.userJoin.Text = "Join";
            this.userJoin.UseVisualStyleBackColor = false;
            this.userJoin.Click += new System.EventHandler(this.userJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(152, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Userid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(152, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(152, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginFormN
            // 
            this.LoginFormN.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginFormN.FlatAppearance.BorderSize = 0;
            this.LoginFormN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginFormN.Location = new System.Drawing.Point(615, 360);
            this.LoginFormN.Name = "LoginFormN";
            this.LoginFormN.Size = new System.Drawing.Size(173, 57);
            this.LoginFormN.TabIndex = 3;
            this.LoginFormN.Text = "LoginPage";
            this.LoginFormN.UseVisualStyleBackColor = false;
            this.LoginFormN.Click += new System.EventHandler(this.LoginFormN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(156, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(156, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(156, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(161, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 182);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginFormN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userJoin);
            this.Controls.Add(this.idCheck);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userPw);
            this.Controls.Add(this.userId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userPw;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button idCheck;
        private System.Windows.Forms.Button userJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LoginFormN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


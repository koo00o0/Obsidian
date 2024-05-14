namespace test
{
    partial class JoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.idCheck = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.txtQUESTION = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtANSWER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPW2 = new System.Windows.Forms.TextBox();
            this.Gologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(148, 61);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(190, 28);
            this.txtNAME.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(149, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 28);
            this.txtID.TabIndex = 6;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(148, 161);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(190, 28);
            this.txtPW.TabIndex = 7;
            // 
            // idCheck
            // 
            this.idCheck.Location = new System.Drawing.Point(345, 110);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(180, 32);
            this.idCheck.TabIndex = 7;
            this.idCheck.Text = "아이디 중복확인";
            this.idCheck.UseVisualStyleBackColor = true;
            this.idCheck.Click += new System.EventHandler(this.idCheck_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(552, 220);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(207, 117);
            this.signup.TabIndex = 11;
            this.signup.Text = "회원가입";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click_1);
            // 
            // txtQUESTION
            // 
            this.txtQUESTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQUESTION.FormattingEnabled = true;
            this.txtQUESTION.Location = new System.Drawing.Point(148, 261);
            this.txtQUESTION.Name = "txtQUESTION";
            this.txtQUESTION.Size = new System.Drawing.Size(242, 26);
            this.txtQUESTION.TabIndex = 9;
            this.txtQUESTION.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "질문선택";
            // 
            // txtANSWER
            // 
            this.txtANSWER.Location = new System.Drawing.Point(149, 304);
            this.txtANSWER.Name = "txtANSWER";
            this.txtANSWER.Size = new System.Drawing.Size(190, 28);
            this.txtANSWER.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "질문답";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "비밀번호 확인";
            // 
            // txtPW2
            // 
            this.txtPW2.Location = new System.Drawing.Point(149, 211);
            this.txtPW2.Name = "txtPW2";
            this.txtPW2.PasswordChar = '*';
            this.txtPW2.Size = new System.Drawing.Size(190, 28);
            this.txtPW2.TabIndex = 8;
            // 
            // Gologin
            // 
            this.Gologin.Location = new System.Drawing.Point(552, 61);
            this.Gologin.Name = "Gologin";
            this.Gologin.Size = new System.Drawing.Size(207, 114);
            this.Gologin.TabIndex = 20;
            this.Gologin.Text = "로그인 화면";
            this.Gologin.UseVisualStyleBackColor = true;
            this.Gologin.Click += new System.EventHandler(this.Gologin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 421);
            this.Controls.Add(this.Gologin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtANSWER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQUESTION);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.idCheck);
            this.Controls.Add(this.txtPW2);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button idCheck;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.ComboBox txtQUESTION;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtANSWER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPW2;
        private System.Windows.Forms.Button Gologin;
    }
}
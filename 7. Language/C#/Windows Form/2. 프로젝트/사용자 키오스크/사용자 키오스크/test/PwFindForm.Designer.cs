namespace test
{
    partial class PwFindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtANSWER = new System.Windows.Forms.TextBox();
            this.txtQUESTION = new System.Windows.Forms.ComboBox();
            this.findpassword = new System.Windows.Forms.Button();
            this.gologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "질문 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "질문답";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(179, 66);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(192, 28);
            this.txtNAME.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(179, 117);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 28);
            this.txtID.TabIndex = 5;
            // 
            // txtANSWER
            // 
            this.txtANSWER.Location = new System.Drawing.Point(179, 215);
            this.txtANSWER.Name = "txtANSWER";
            this.txtANSWER.Size = new System.Drawing.Size(192, 28);
            this.txtANSWER.TabIndex = 7;
            // 
            // txtQUESTION
            // 
            this.txtQUESTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQUESTION.FormattingEnabled = true;
            this.txtQUESTION.Location = new System.Drawing.Point(179, 167);
            this.txtQUESTION.Name = "txtQUESTION";
            this.txtQUESTION.Size = new System.Drawing.Size(233, 26);
            this.txtQUESTION.TabIndex = 6;
            this.txtQUESTION.SelectedIndexChanged += new System.EventHandler(this.txtQUESTION_SelectedIndexChanged);
            // 
            // findpassword
            // 
            this.findpassword.Location = new System.Drawing.Point(179, 271);
            this.findpassword.Name = "findpassword";
            this.findpassword.Size = new System.Drawing.Size(192, 99);
            this.findpassword.TabIndex = 8;
            this.findpassword.Text = "비밀번호찾기";
            this.findpassword.UseVisualStyleBackColor = true;
            this.findpassword.Click += new System.EventHandler(this.findpassword_Click);
            // 
            // gologin
            // 
            this.gologin.Location = new System.Drawing.Point(467, 66);
            this.gologin.Name = "gologin";
            this.gologin.Size = new System.Drawing.Size(183, 127);
            this.gologin.TabIndex = 9;
            this.gologin.Text = "로그인 화면";
            this.gologin.UseVisualStyleBackColor = true;
            this.gologin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 413);
            this.Controls.Add(this.gologin);
            this.Controls.Add(this.findpassword);
            this.Controls.Add(this.txtQUESTION);
            this.Controls.Add(this.txtANSWER);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtANSWER;
        private System.Windows.Forms.ComboBox txtQUESTION;
        private System.Windows.Forms.Button findpassword;
        private System.Windows.Forms.Button gologin;
    }
}
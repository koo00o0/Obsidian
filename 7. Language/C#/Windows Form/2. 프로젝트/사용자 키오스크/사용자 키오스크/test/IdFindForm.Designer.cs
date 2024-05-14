namespace test
{
    partial class IdFindForm
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
            this.gologin = new System.Windows.Forms.Button();
            this.findid = new System.Windows.Forms.Button();
            this.txtQUESTION = new System.Windows.Forms.ComboBox();
            this.txtANSWER = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gologin
            // 
            this.gologin.Location = new System.Drawing.Point(451, 66);
            this.gologin.Name = "gologin";
            this.gologin.Size = new System.Drawing.Size(183, 127);
            this.gologin.TabIndex = 19;
            this.gologin.Text = "로그인 화면";
            this.gologin.UseVisualStyleBackColor = true;
            this.gologin.Click += new System.EventHandler(this.button2_Click);
            // 
            // findid
            // 
            this.findid.Location = new System.Drawing.Point(163, 271);
            this.findid.Name = "findid";
            this.findid.Size = new System.Drawing.Size(192, 99);
            this.findid.TabIndex = 18;
            this.findid.Text = "아이디찾기";
            this.findid.UseVisualStyleBackColor = true;
            this.findid.Click += new System.EventHandler(this.findid_Click);
            // 
            // txtQUESTION
            // 
            this.txtQUESTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQUESTION.FormattingEnabled = true;
            this.txtQUESTION.Location = new System.Drawing.Point(163, 167);
            this.txtQUESTION.Name = "txtQUESTION";
            this.txtQUESTION.Size = new System.Drawing.Size(233, 26);
            this.txtQUESTION.TabIndex = 16;
            this.txtQUESTION.SelectedIndexChanged += new System.EventHandler(this.txtQUESTION_SelectedIndexChanged);
            // 
            // txtANSWER
            // 
            this.txtANSWER.Location = new System.Drawing.Point(163, 215);
            this.txtANSWER.Name = "txtANSWER";
            this.txtANSWER.Size = new System.Drawing.Size(192, 28);
            this.txtANSWER.TabIndex = 17;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(163, 117);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(192, 28);
            this.txtPASSWORD.TabIndex = 15;
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(163, 66);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(192, 28);
            this.txtNAME.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "질문답";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "질문 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "이름";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 432);
            this.Controls.Add(this.gologin);
            this.Controls.Add(this.findid);
            this.Controls.Add(this.txtQUESTION);
            this.Controls.Add(this.txtANSWER);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gologin;
        private System.Windows.Forms.Button findid;
        private System.Windows.Forms.ComboBox txtQUESTION;
        private System.Windows.Forms.TextBox txtANSWER;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
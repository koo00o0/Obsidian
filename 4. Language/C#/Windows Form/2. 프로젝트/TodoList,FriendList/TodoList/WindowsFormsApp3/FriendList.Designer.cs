namespace WindowsFormsApp3
{
    partial class FriendList
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
            this.FriendListBox = new System.Windows.Forms.ListBox();
            this.FriendFindBtn = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.FriendFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RequestFriend = new System.Windows.Forms.ListBox();
            this.WaitRequest = new System.Windows.Forms.ListBox();
            this.LoginIdText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FriendListBox
            // 
            this.FriendListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendListBox.FormattingEnabled = true;
            this.FriendListBox.ItemHeight = 25;
            this.FriendListBox.Location = new System.Drawing.Point(74, 373);
            this.FriendListBox.Name = "FriendListBox";
            this.FriendListBox.Size = new System.Drawing.Size(625, 279);
            this.FriendListBox.TabIndex = 0;
            this.FriendListBox.SelectedIndexChanged += new System.EventHandler(this.FriendListBox_SelectedIndexChanged);
            // 
            // FriendFindBtn
            // 
            this.FriendFindBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.FriendFindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendFindBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FriendFindBtn.Location = new System.Drawing.Point(337, 52);
            this.FriendFindBtn.Name = "FriendFindBtn";
            this.FriendFindBtn.Size = new System.Drawing.Size(103, 40);
            this.FriendFindBtn.TabIndex = 1;
            this.FriendFindBtn.Text = "친구검색";
            this.FriendFindBtn.UseVisualStyleBackColor = false;
            this.FriendFindBtn.Click += new System.EventHandler(this.FriendFindBtn_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.a.Location = new System.Drawing.Point(49, 56);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(89, 29);
            this.a.TabIndex = 2;
            this.a.Text = "친구찾기";
            // 
            // FriendFind
            // 
            this.FriendFind.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FriendFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendFind.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendFind.Location = new System.Drawing.Point(131, 61);
            this.FriendFind.Name = "FriendFind";
            this.FriendFind.Size = new System.Drawing.Size(164, 22);
            this.FriendFind.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(694, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "MainPage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestFriend
            // 
            this.RequestFriend.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestFriend.FormattingEnabled = true;
            this.RequestFriend.ItemHeight = 22;
            this.RequestFriend.Location = new System.Drawing.Point(74, 129);
            this.RequestFriend.Name = "RequestFriend";
            this.RequestFriend.Size = new System.Drawing.Size(625, 70);
            this.RequestFriend.TabIndex = 5;
            // 
            // WaitRequest
            // 
            this.WaitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitRequest.FormattingEnabled = true;
            this.WaitRequest.ItemHeight = 20;
            this.WaitRequest.Location = new System.Drawing.Point(74, 252);
            this.WaitRequest.Name = "WaitRequest";
            this.WaitRequest.Size = new System.Drawing.Size(625, 84);
            this.WaitRequest.TabIndex = 5;
            // 
            // LoginIdText
            // 
            this.LoginIdText.AutoSize = true;
            this.LoginIdText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginIdText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginIdText.Location = new System.Drawing.Point(509, 49);
            this.LoginIdText.Name = "LoginIdText";
            this.LoginIdText.Size = new System.Drawing.Size(100, 35);
            this.LoginIdText.TabIndex = 7;
            this.LoginIdText.Text = "LoginID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(131, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(69, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "요청중";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(74, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "친구";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(69, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "친구 대기";
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 808);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginIdText);
            this.Controls.Add(this.WaitRequest);
            this.Controls.Add(this.RequestFriend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FriendFind);
            this.Controls.Add(this.a);
            this.Controls.Add(this.FriendFindBtn);
            this.Controls.Add(this.FriendListBox);
            this.Name = "FriendList";
            this.Text = "FriendLlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FriendListBox;
        private System.Windows.Forms.Button FriendFindBtn;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox FriendFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RequestFriend;
        private System.Windows.Forms.ListBox WaitRequest;
        private System.Windows.Forms.Label LoginIdText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
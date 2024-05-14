namespace test
{
    partial class Adminpage
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
            this.UserProfileBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AIdsession = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserProfileBox
            // 
            this.UserProfileBox.Font = new System.Drawing.Font("굴림", 12.5F);
            this.UserProfileBox.FormattingEnabled = true;
            this.UserProfileBox.ItemHeight = 21;
            this.UserProfileBox.Location = new System.Drawing.Point(296, 81);
            this.UserProfileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserProfileBox.Name = "UserProfileBox";
            this.UserProfileBox.Size = new System.Drawing.Size(359, 298);
            this.UserProfileBox.TabIndex = 0;
            this.UserProfileBox.SelectedIndexChanged += new System.EventHandler(this.UserProfileBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "관리자화면";
            // 
            // AIdsession
            // 
            this.AIdsession.AutoSize = true;
            this.AIdsession.Font = new System.Drawing.Font("굴림", 15F);
            this.AIdsession.Location = new System.Drawing.Point(21, 81);
            this.AIdsession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AIdsession.Name = "AIdsession";
            this.AIdsession.Size = new System.Drawing.Size(87, 25);
            this.AIdsession.TabIndex = 2;
            this.AIdsession.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "회원목록";
            // 
            // MenuManagement
            // 
            this.MenuManagement.Location = new System.Drawing.Point(26, 229);
            this.MenuManagement.Name = "MenuManagement";
            this.MenuManagement.Size = new System.Drawing.Size(203, 36);
            this.MenuManagement.TabIndex = 4;
            this.MenuManagement.Text = "메뉴관리";
            this.MenuManagement.UseVisualStyleBackColor = true;
            this.MenuManagement.Click += new System.EventHandler(this.MenuManagement_Click);
            // 
            // Adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 435);
            this.Controls.Add(this.MenuManagement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AIdsession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserProfileBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Adminpage";
            this.Text = "Adminpage";
            this.Load += new System.EventHandler(this.UserProfile_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserProfileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AIdsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MenuManagement;
    }
}
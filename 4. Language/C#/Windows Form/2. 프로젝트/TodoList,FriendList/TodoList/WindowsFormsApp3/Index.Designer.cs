namespace WindowsFormsApp3
{
    partial class Index
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
            this.SaveProfilePicture = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ChangeProfilePicture = new System.Windows.Forms.Button();
            this.FriendListPage = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.todolist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveProfilePicture
            // 
            this.SaveProfilePicture.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveProfilePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveProfilePicture.FlatAppearance.BorderSize = 0;
            this.SaveProfilePicture.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProfilePicture.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveProfilePicture.Location = new System.Drawing.Point(606, 331);
            this.SaveProfilePicture.Name = "SaveProfilePicture";
            this.SaveProfilePicture.Size = new System.Drawing.Size(106, 31);
            this.SaveProfilePicture.TabIndex = 12;
            this.SaveProfilePicture.Text = "프로필 저장";
            this.SaveProfilePicture.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Location = new System.Drawing.Point(504, 49);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(208, 174);
            this.pictureBoxProfile.TabIndex = 11;
            this.pictureBoxProfile.TabStop = false;
            // 
            // ChangeProfilePicture
            // 
            this.ChangeProfilePicture.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangeProfilePicture.FlatAppearance.BorderSize = 0;
            this.ChangeProfilePicture.Font = new System.Drawing.Font("Magneto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeProfilePicture.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChangeProfilePicture.Location = new System.Drawing.Point(584, 244);
            this.ChangeProfilePicture.Name = "ChangeProfilePicture";
            this.ChangeProfilePicture.Size = new System.Drawing.Size(128, 59);
            this.ChangeProfilePicture.TabIndex = 10;
            this.ChangeProfilePicture.Text = "프로필 변경";
            this.ChangeProfilePicture.UseVisualStyleBackColor = false;
            // 
            // FriendListPage
            // 
            this.FriendListPage.BackColor = System.Drawing.Color.SkyBlue;
            this.FriendListPage.FlatAppearance.BorderSize = 0;
            this.FriendListPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendListPage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FriendListPage.Location = new System.Drawing.Point(57, 300);
            this.FriendListPage.Name = "FriendListPage";
            this.FriendListPage.Size = new System.Drawing.Size(171, 62);
            this.FriendListPage.TabIndex = 7;
            this.FriendListPage.Text = "FriendList";
            this.FriendListPage.UseVisualStyleBackColor = false;
            this.FriendListPage.Click += new System.EventHandler(this.FriendListPage_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SkyBlue;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logout.Location = new System.Drawing.Point(57, 135);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(130, 47);
            this.logout.TabIndex = 8;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // todolist
            // 
            this.todolist.BackColor = System.Drawing.Color.SkyBlue;
            this.todolist.FlatAppearance.BorderSize = 0;
            this.todolist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todolist.ForeColor = System.Drawing.SystemColors.Highlight;
            this.todolist.Location = new System.Drawing.Point(57, 198);
            this.todolist.Name = "todolist";
            this.todolist.Size = new System.Drawing.Size(171, 62);
            this.todolist.TabIndex = 9;
            this.todolist.Text = "TODOLIST";
            this.todolist.UseVisualStyleBackColor = false;
            this.todolist.Click += new System.EventHandler(this.todolist_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(361, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "프로필";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "메인";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveProfilePicture);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.ChangeProfilePicture);
            this.Controls.Add(this.FriendListPage);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.todolist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button ChangeProfilePicture;
        private System.Windows.Forms.Button FriendListPage;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button todolist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonShowAllFriends = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.labelCurrentPostLikes = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxAbout = new System.Windows.Forms.ListBox();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.labelMyFriends = new System.Windows.Forms.Label();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.labelMyPages = new System.Windows.Forms.Label();
            this.buttonShowAllPages = new System.Windows.Forms.Button();
            this.labelMyGroups = new System.Windows.Forms.Label();
            this.buttonShowAllGroups = new System.Windows.Forms.Button();
            this.labelMyEvents = new System.Windows.Forms.Label();
            this.buttonShowAllEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 62);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.Location = new System.Drawing.Point(18, 106);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(160, 26);
            this.checkBoxRememberMe.TabIndex = 53;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(293, 17);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(635, 131);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 54;
            this.pictureBoxCover.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(553, 67);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(120, 142);
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(18, 235);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(138, 84);
            this.listBoxFriends.TabIndex = 56;
            // 
            // buttonShowAllFriends
            // 
            this.buttonShowAllFriends.AutoSize = true;
            this.buttonShowAllFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllFriends.Location = new System.Drawing.Point(18, 327);
            this.buttonShowAllFriends.Name = "buttonShowAllFriends";
            this.buttonShowAllFriends.Size = new System.Drawing.Size(138, 30);
            this.buttonShowAllFriends.TabIndex = 57;
            this.buttonShowAllFriends.Text = "Show all friends";
            this.buttonShowAllFriends.UseVisualStyleBackColor = true;
            this.buttonShowAllFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(190, 235);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(656, 124);
            this.listBoxPosts.TabIndex = 58;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 20;
            this.listBoxPostComments.Location = new System.Drawing.Point(852, 255);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(271, 104);
            this.listBoxPostComments.TabIndex = 59;
            // 
            // labelCurrentPostLikes
            // 
            this.labelCurrentPostLikes.Location = new System.Drawing.Point(852, 227);
            this.labelCurrentPostLikes.Name = "labelCurrentPostLikes";
            this.labelCurrentPostLikes.Size = new System.Drawing.Size(166, 25);
            this.labelCurrentPostLikes.TabIndex = 60;
            this.labelCurrentPostLikes.Text = "Likes:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 20;
            this.listBoxPages.Location = new System.Drawing.Point(979, 404);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(271, 44);
            this.listBoxPages.TabIndex = 61;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(979, 503);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(271, 44);
            this.listBoxGroups.TabIndex = 62;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(979, 602);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(271, 44);
            this.listBoxEvents.TabIndex = 64;
            // 
            // listBoxAbout
            // 
            this.listBoxAbout.FormattingEnabled = true;
            this.listBoxAbout.ItemHeight = 20;
            this.listBoxAbout.Location = new System.Drawing.Point(935, 18);
            this.listBoxAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAbout.Name = "listBoxAbout";
            this.listBoxAbout.Size = new System.Drawing.Size(223, 124);
            this.listBoxAbout.TabIndex = 65;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.ItemHeight = 20;
            this.listBoxCheckIns.Location = new System.Drawing.Point(575, 404);
            this.listBoxCheckIns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(271, 44);
            this.listBoxCheckIns.TabIndex = 66;
            // 
            // labelMyFriends
            // 
            this.labelMyFriends.AutoSize = true;
            this.labelMyFriends.Location = new System.Drawing.Point(18, 209);
            this.labelMyFriends.Name = "labelMyFriends";
            this.labelMyFriends.Size = new System.Drawing.Size(97, 20);
            this.labelMyFriends.TabIndex = 68;
            this.labelMyFriends.Text = "My Friends:";
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Location = new System.Drawing.Point(186, 209);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(84, 20);
            this.labelMyPosts.TabIndex = 69;
            this.labelMyPosts.Text = "My Posts:";
            // 
            // labelMyPages
            // 
            this.labelMyPages.AutoSize = true;
            this.labelMyPages.Location = new System.Drawing.Point(884, 404);
            this.labelMyPages.Name = "labelMyPages";
            this.labelMyPages.Size = new System.Drawing.Size(88, 20);
            this.labelMyPages.TabIndex = 70;
            this.labelMyPages.Text = "My Pages:";
            // 
            // buttonShowAllPages
            // 
            this.buttonShowAllPages.AutoSize = true;
            this.buttonShowAllPages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllPages.Location = new System.Drawing.Point(979, 456);
            this.buttonShowAllPages.Name = "buttonShowAllPages";
            this.buttonShowAllPages.Size = new System.Drawing.Size(137, 30);
            this.buttonShowAllPages.TabIndex = 71;
            this.buttonShowAllPages.Text = "Show my pages";
            this.buttonShowAllPages.UseVisualStyleBackColor = true;
            this.buttonShowAllPages.Click += new System.EventHandler(this.buttonShowAllPages_Click);
            // 
            // labelMyGroups
            // 
            this.labelMyGroups.AutoSize = true;
            this.labelMyGroups.Location = new System.Drawing.Point(884, 503);
            this.labelMyGroups.Name = "labelMyGroups";
            this.labelMyGroups.Size = new System.Drawing.Size(96, 20);
            this.labelMyGroups.TabIndex = 72;
            this.labelMyGroups.Text = "My Groups:";
            // 
            // buttonShowAllGroups
            // 
            this.buttonShowAllGroups.AutoSize = true;
            this.buttonShowAllGroups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllGroups.Location = new System.Drawing.Point(979, 555);
            this.buttonShowAllGroups.Name = "buttonShowAllGroups";
            this.buttonShowAllGroups.Size = new System.Drawing.Size(143, 30);
            this.buttonShowAllGroups.TabIndex = 73;
            this.buttonShowAllGroups.Text = "Show my groups";
            this.buttonShowAllGroups.UseVisualStyleBackColor = true;
            this.buttonShowAllGroups.Click += new System.EventHandler(this.buttonShowAllGroups_Click);
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Location = new System.Drawing.Point(884, 602);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(92, 20);
            this.labelMyEvents.TabIndex = 74;
            this.labelMyEvents.Text = "My Events:";
            // 
            // buttonShowAllEvents
            // 
            this.buttonShowAllEvents.AutoSize = true;
            this.buttonShowAllEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllEvents.Location = new System.Drawing.Point(979, 654);
            this.buttonShowAllEvents.Name = "buttonShowAllEvents";
            this.buttonShowAllEvents.Size = new System.Drawing.Size(141, 30);
            this.buttonShowAllEvents.TabIndex = 75;
            this.buttonShowAllEvents.Text = "Show my events";
            this.buttonShowAllEvents.UseVisualStyleBackColor = true;
            this.buttonShowAllEvents.Click += new System.EventHandler(this.buttonShowAllEvents_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 749);
            this.Controls.Add(this.buttonShowAllEvents);
            this.Controls.Add(this.labelMyEvents);
            this.Controls.Add(this.buttonShowAllGroups);
            this.Controls.Add(this.labelMyGroups);
            this.Controls.Add(this.buttonShowAllPages);
            this.Controls.Add(this.labelMyPages);
            this.Controls.Add(this.labelMyPosts);
            this.Controls.Add(this.labelMyFriends);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.listBoxAbout);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.labelCurrentPostLikes);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonShowAllFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonShowAllFriends;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Label labelCurrentPostLikes;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxAbout;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Label labelMyFriends;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.Label labelMyPages;
        private System.Windows.Forms.Button buttonShowAllPages;
        private System.Windows.Forms.Label labelMyGroups;
        private System.Windows.Forms.Button buttonShowAllGroups;
        private System.Windows.Forms.Label labelMyEvents;
        private System.Windows.Forms.Button buttonShowAllEvents;
    }
}

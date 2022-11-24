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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowAllAlbums = new System.Windows.Forms.Button();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxChange = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 40);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.Location = new System.Drawing.Point(12, 69);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(107, 17);
            this.checkBoxRememberMe.TabIndex = 53;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(195, 11);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(423, 85);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 54;
            this.pictureBoxCover.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(369, 44);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(80, 92);
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(81, 263);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(178, 30);
            this.listBoxFriends.TabIndex = 56;
            // 
            // buttonShowAllFriends
            // 
            this.buttonShowAllFriends.AutoSize = true;
            this.buttonShowAllFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllFriends.Location = new System.Drawing.Point(81, 297);
            this.buttonShowAllFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAllFriends.Name = "buttonShowAllFriends";
            this.buttonShowAllFriends.Size = new System.Drawing.Size(91, 23);
            this.buttonShowAllFriends.TabIndex = 57;
            this.buttonShowAllFriends.Text = "Show all friends";
            this.buttonShowAllFriends.UseVisualStyleBackColor = true;
            this.buttonShowAllFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 155);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(535, 82);
            this.listBoxPosts.TabIndex = 58;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.Location = new System.Drawing.Point(566, 181);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(182, 56);
            this.listBoxPostComments.TabIndex = 59;
            // 
            // labelCurrentPostLikes
            // 
            this.labelCurrentPostLikes.Location = new System.Drawing.Point(563, 155);
            this.labelCurrentPostLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentPostLikes.Name = "labelCurrentPostLikes";
            this.labelCurrentPostLikes.Size = new System.Drawing.Size(53, 16);
            this.labelCurrentPostLikes.TabIndex = 60;
            this.labelCurrentPostLikes.Text = "Likes:";
            this.labelCurrentPostLikes.Click += new System.EventHandler(this.labelCurrentPostLikes_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(344, 263);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(182, 30);
            this.listBoxPages.TabIndex = 61;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(344, 327);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(182, 30);
            this.listBoxGroups.TabIndex = 62;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(344, 391);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(182, 30);
            this.listBoxEvents.TabIndex = 64;
            // 
            // listBoxAbout
            // 
            this.listBoxAbout.FormattingEnabled = true;
            this.listBoxAbout.Location = new System.Drawing.Point(623, 12);
            this.listBoxAbout.Name = "listBoxAbout";
            this.listBoxAbout.Size = new System.Drawing.Size(150, 82);
            this.listBoxAbout.TabIndex = 65;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(81, 452);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(178, 30);
            this.listBoxCheckIns.TabIndex = 66;
            // 
            // labelMyFriends
            // 
            this.labelMyFriends.AutoSize = true;
            this.labelMyFriends.Location = new System.Drawing.Point(11, 263);
            this.labelMyFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyFriends.Name = "labelMyFriends";
            this.labelMyFriends.Size = new System.Drawing.Size(61, 13);
            this.labelMyFriends.TabIndex = 68;
            this.labelMyFriends.Text = "My Friends:";
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Location = new System.Drawing.Point(9, 138);
            this.labelMyPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(53, 13);
            this.labelMyPosts.TabIndex = 69;
            this.labelMyPosts.Text = "My Posts:";
            // 
            // labelMyPages
            // 
            this.labelMyPages.AutoSize = true;
            this.labelMyPages.Location = new System.Drawing.Point(280, 263);
            this.labelMyPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPages.Name = "labelMyPages";
            this.labelMyPages.Size = new System.Drawing.Size(57, 13);
            this.labelMyPages.TabIndex = 70;
            this.labelMyPages.Text = "My Pages:";
            // 
            // buttonShowAllPages
            // 
            this.buttonShowAllPages.AutoSize = true;
            this.buttonShowAllPages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllPages.Location = new System.Drawing.Point(344, 296);
            this.buttonShowAllPages.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAllPages.Name = "buttonShowAllPages";
            this.buttonShowAllPages.Size = new System.Drawing.Size(92, 23);
            this.buttonShowAllPages.TabIndex = 71;
            this.buttonShowAllPages.Text = "Show my pages";
            this.buttonShowAllPages.UseVisualStyleBackColor = true;
            this.buttonShowAllPages.Click += new System.EventHandler(this.buttonShowAllPages_Click);
            // 
            // labelMyGroups
            // 
            this.labelMyGroups.AutoSize = true;
            this.labelMyGroups.Location = new System.Drawing.Point(280, 327);
            this.labelMyGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyGroups.Name = "labelMyGroups";
            this.labelMyGroups.Size = new System.Drawing.Size(61, 13);
            this.labelMyGroups.TabIndex = 72;
            this.labelMyGroups.Text = "My Groups:";
            // 
            // buttonShowAllGroups
            // 
            this.buttonShowAllGroups.AutoSize = true;
            this.buttonShowAllGroups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllGroups.Location = new System.Drawing.Point(344, 361);
            this.buttonShowAllGroups.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAllGroups.Name = "buttonShowAllGroups";
            this.buttonShowAllGroups.Size = new System.Drawing.Size(95, 23);
            this.buttonShowAllGroups.TabIndex = 73;
            this.buttonShowAllGroups.Text = "Show my groups";
            this.buttonShowAllGroups.UseVisualStyleBackColor = true;
            this.buttonShowAllGroups.Click += new System.EventHandler(this.buttonShowAllGroups_Click);
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Location = new System.Drawing.Point(280, 391);
            this.labelMyEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(60, 13);
            this.labelMyEvents.TabIndex = 74;
            this.labelMyEvents.Text = "My Events:";
            // 
            // buttonShowAllEvents
            // 
            this.buttonShowAllEvents.AutoSize = true;
            this.buttonShowAllEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllEvents.Location = new System.Drawing.Point(344, 425);
            this.buttonShowAllEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAllEvents.Name = "buttonShowAllEvents";
            this.buttonShowAllEvents.Size = new System.Drawing.Size(95, 23);
            this.buttonShowAllEvents.TabIndex = 75;
            this.buttonShowAllEvents.Text = "Show my events";
            this.buttonShowAllEvents.UseVisualStyleBackColor = true;
            this.buttonShowAllEvents.Click += new System.EventHandler(this.buttonShowAllEvents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "My Checkins:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(81, 327);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(178, 30);
            this.listBoxAlbums.TabIndex = 77;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "My Albums:";
            // 
            // buttonShowAllAlbums
            // 
            this.buttonShowAllAlbums.AutoSize = true;
            this.buttonShowAllAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllAlbums.Location = new System.Drawing.Point(81, 362);
            this.buttonShowAllAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAllAlbums.Name = "buttonShowAllAlbums";
            this.buttonShowAllAlbums.Size = new System.Drawing.Size(93, 23);
            this.buttonShowAllAlbums.TabIndex = 79;
            this.buttonShowAllAlbums.Text = "Show all albums";
            this.buttonShowAllAlbums.UseVisualStyleBackColor = true;
            this.buttonShowAllAlbums.Click += new System.EventHandler(this.buttonShowAllAlbums_Click);
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Location = new System.Drawing.Point(81, 390);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(110, 52);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 80;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // pictureBoxChange
            // 
            this.pictureBoxChange.Location = new System.Drawing.Point(551, 263);
            this.pictureBoxChange.Name = "pictureBoxChange";
            this.pictureBoxChange.Size = new System.Drawing.Size(264, 202);
            this.pictureBoxChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChange.TabIndex = 81;
            this.pictureBoxChange.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 487);
            this.Controls.Add(this.pictureBoxChange);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.buttonShowAllAlbums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.label1);
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowAllAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxChange;
        private System.Windows.Forms.Timer timer1;
    }
}

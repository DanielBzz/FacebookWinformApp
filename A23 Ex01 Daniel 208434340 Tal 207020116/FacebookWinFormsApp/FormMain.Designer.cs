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
            this.buttonLogout = new System.Windows.Forms.Button();
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
            this.labelMyFriends = new System.Windows.Forms.Label();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.labelMyPages = new System.Windows.Forms.Label();
            this.buttonShowAllPages = new System.Windows.Forms.Button();
            this.labelMyGroups = new System.Windows.Forms.Label();
            this.buttonShowAllGroups = new System.Windows.Forms.Button();
            this.labelMyEvents = new System.Windows.Forms.Label();
            this.buttonShowAllEvents = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowAllAlbums = new System.Windows.Forms.Button();
            this.pictureBoxChange = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFindFriends = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(260, 14);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(564, 105);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 54;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(492, 54);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(107, 113);
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(108, 324);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(208, 36);
            this.listBoxFriends.TabIndex = 56;
            // 
            // buttonShowAllFriends
            // 
            this.buttonShowAllFriends.AutoSize = true;
            this.buttonShowAllFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllFriends.Location = new System.Drawing.Point(108, 366);
            this.buttonShowAllFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllFriends.Name = "buttonShowAllFriends";
            this.buttonShowAllFriends.Size = new System.Drawing.Size(117, 27);
            this.buttonShowAllFriends.TabIndex = 57;
            this.buttonShowAllFriends.Text = "Show all friends";
            this.buttonShowAllFriends.UseVisualStyleBackColor = true;
            this.buttonShowAllFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 191);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(712, 100);
            this.listBoxPosts.TabIndex = 58;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 16;
            this.listBoxPostComments.Location = new System.Drawing.Point(755, 223);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(241, 68);
            this.listBoxPostComments.TabIndex = 59;
            // 
            // labelCurrentPostLikes
            // 
            this.labelCurrentPostLikes.Location = new System.Drawing.Point(751, 191);
            this.labelCurrentPostLikes.Name = "labelCurrentPostLikes";
            this.labelCurrentPostLikes.Size = new System.Drawing.Size(71, 20);
            this.labelCurrentPostLikes.TabIndex = 60;
            this.labelCurrentPostLikes.Text = "Likes:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(448, 324);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(229, 36);
            this.listBoxPages.TabIndex = 61;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(448, 407);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(229, 36);
            this.listBoxGroups.TabIndex = 62;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(448, 499);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(229, 36);
            this.listBoxEvents.TabIndex = 64;
            // 
            // listBoxAbout
            // 
            this.listBoxAbout.FormattingEnabled = true;
            this.listBoxAbout.ItemHeight = 16;
            this.listBoxAbout.Location = new System.Drawing.Point(831, 15);
            this.listBoxAbout.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAbout.Name = "listBoxAbout";
            this.listBoxAbout.Size = new System.Drawing.Size(199, 100);
            this.listBoxAbout.TabIndex = 65;
            // 
            // labelMyFriends
            // 
            this.labelMyFriends.AutoSize = true;
            this.labelMyFriends.Location = new System.Drawing.Point(15, 324);
            this.labelMyFriends.Name = "labelMyFriends";
            this.labelMyFriends.Size = new System.Drawing.Size(81, 17);
            this.labelMyFriends.TabIndex = 68;
            this.labelMyFriends.Text = "My Friends:";
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Location = new System.Drawing.Point(12, 170);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(69, 17);
            this.labelMyPosts.TabIndex = 69;
            this.labelMyPosts.Text = "My Posts:";
            // 
            // labelMyPages
            // 
            this.labelMyPages.AutoSize = true;
            this.labelMyPages.Location = new System.Drawing.Point(362, 324);
            this.labelMyPages.Name = "labelMyPages";
            this.labelMyPages.Size = new System.Drawing.Size(74, 17);
            this.labelMyPages.TabIndex = 70;
            this.labelMyPages.Text = "My Pages:";
            // 
            // buttonShowAllPages
            // 
            this.buttonShowAllPages.AutoSize = true;
            this.buttonShowAllPages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllPages.Location = new System.Drawing.Point(448, 364);
            this.buttonShowAllPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllPages.Name = "buttonShowAllPages";
            this.buttonShowAllPages.Size = new System.Drawing.Size(117, 27);
            this.buttonShowAllPages.TabIndex = 71;
            this.buttonShowAllPages.Text = "Show my pages";
            this.buttonShowAllPages.UseVisualStyleBackColor = true;
            this.buttonShowAllPages.Click += new System.EventHandler(this.buttonShowAllPages_Click);
            // 
            // labelMyGroups
            // 
            this.labelMyGroups.AutoSize = true;
            this.labelMyGroups.Location = new System.Drawing.Point(362, 407);
            this.labelMyGroups.Name = "labelMyGroups";
            this.labelMyGroups.Size = new System.Drawing.Size(81, 17);
            this.labelMyGroups.TabIndex = 72;
            this.labelMyGroups.Text = "My Groups:";
            // 
            // buttonShowAllGroups
            // 
            this.buttonShowAllGroups.AutoSize = true;
            this.buttonShowAllGroups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllGroups.Location = new System.Drawing.Point(448, 449);
            this.buttonShowAllGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllGroups.Name = "buttonShowAllGroups";
            this.buttonShowAllGroups.Size = new System.Drawing.Size(122, 27);
            this.buttonShowAllGroups.TabIndex = 73;
            this.buttonShowAllGroups.Text = "Show my groups";
            this.buttonShowAllGroups.UseVisualStyleBackColor = true;
            this.buttonShowAllGroups.Click += new System.EventHandler(this.buttonShowAllGroups_Click);
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Location = new System.Drawing.Point(362, 499);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(77, 17);
            this.labelMyEvents.TabIndex = 74;
            this.labelMyEvents.Text = "My Events:";
            // 
            // buttonShowAllEvents
            // 
            this.buttonShowAllEvents.AutoSize = true;
            this.buttonShowAllEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllEvents.Location = new System.Drawing.Point(448, 541);
            this.buttonShowAllEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllEvents.Name = "buttonShowAllEvents";
            this.buttonShowAllEvents.Size = new System.Drawing.Size(120, 27);
            this.buttonShowAllEvents.TabIndex = 75;
            this.buttonShowAllEvents.Text = "Show my events";
            this.buttonShowAllEvents.UseVisualStyleBackColor = true;
            this.buttonShowAllEvents.Click += new System.EventHandler(this.buttonShowAllEvents_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(108, 407);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(208, 36);
            this.listBoxAlbums.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "My Albums:";
            // 
            // buttonShowAllAlbums
            // 
            this.buttonShowAllAlbums.AutoSize = true;
            this.buttonShowAllAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowAllAlbums.Location = new System.Drawing.Point(108, 451);
            this.buttonShowAllAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllAlbums.Name = "buttonShowAllAlbums";
            this.buttonShowAllAlbums.Size = new System.Drawing.Size(119, 27);
            this.buttonShowAllAlbums.TabIndex = 79;
            this.buttonShowAllAlbums.Text = "Show all albums";
            this.buttonShowAllAlbums.UseVisualStyleBackColor = true;
            this.buttonShowAllAlbums.Click += new System.EventHandler(this.buttonShowAllAlbums_Click);
            // 
            // pictureBoxChange
            // 
            this.pictureBoxChange.Location = new System.Drawing.Point(774, 324);
            this.pictureBoxChange.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxChange.Name = "pictureBoxChange";
            this.pictureBoxChange.Size = new System.Drawing.Size(332, 249);
            this.pictureBoxChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChange.TabIndex = 81;
            this.pictureBoxChange.TabStop = false;
            this.pictureBoxChange.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonFindFriends
            // 
            this.buttonFindFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindFriends.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindFriends.Location = new System.Drawing.Point(16, 523);
            this.buttonFindFriends.Name = "buttonFindFriends";
            this.buttonFindFriends.Size = new System.Drawing.Size(324, 68);
            this.buttonFindFriends.TabIndex = 82;
            this.buttonFindFriends.Text = "Find My Team";
            this.buttonFindFriends.UseVisualStyleBackColor = true;
            this.buttonFindFriends.Click += new System.EventHandler(this.buttonFindFriends_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(88, 52);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.aToolStripMenuItem.Text = "a";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.bToolStripMenuItem.Text = "b";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 611);
            this.Controls.Add(this.buttonFindFriends);
            this.Controls.Add(this.pictureBoxChange);
            this.Controls.Add(this.buttonShowAllAlbums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonShowAllEvents);
            this.Controls.Add(this.labelMyEvents);
            this.Controls.Add(this.buttonShowAllGroups);
            this.Controls.Add(this.labelMyGroups);
            this.Controls.Add(this.buttonShowAllPages);
            this.Controls.Add(this.labelMyPages);
            this.Controls.Add(this.labelMyPosts);
            this.Controls.Add(this.labelMyFriends);
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
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
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
        private System.Windows.Forms.Label labelMyFriends;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.Label labelMyPages;
        private System.Windows.Forms.Button buttonShowAllPages;
        private System.Windows.Forms.Label labelMyGroups;
        private System.Windows.Forms.Button buttonShowAllGroups;
        private System.Windows.Forms.Label labelMyEvents;
        private System.Windows.Forms.Button buttonShowAllEvents;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowAllAlbums;
        private System.Windows.Forms.PictureBox pictureBoxChange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonFindFriends;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

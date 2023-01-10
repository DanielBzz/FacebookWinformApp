namespace BasicFacebookFeatures
{
    partial class FormFindTeam
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
            System.Windows.Forms.Label likesCountLabel;
            this.labelMain = new System.Windows.Forms.Label();
            this.labelFeatureExplanation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxPages = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.comboBoxMinAge = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxAge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindFriends = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriendsUpdate = new System.Windows.Forms.Label();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            likesCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(12, 25);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(280, 32);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Let\'s find your team";
            // 
            // labelFeatureExplanation
            // 
            this.labelFeatureExplanation.AutoSize = true;
            this.labelFeatureExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeatureExplanation.Location = new System.Drawing.Point(15, 69);
            this.labelFeatureExplanation.Name = "labelFeatureExplanation";
            this.labelFeatureExplanation.Size = new System.Drawing.Size(756, 40);
            this.labelFeatureExplanation.TabIndex = 1;
            this.labelFeatureExplanation.Text = "Discover your friends and open new group according common activities, like same g" +
    "roups and same\r\n pages\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose pages and groups:";
            // 
            // checkedListBoxPages
            // 
            this.checkedListBoxPages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.pageBindingSource, "Name", true));
            this.checkedListBoxPages.FormattingEnabled = true;
            this.checkedListBoxPages.Location = new System.Drawing.Point(17, 159);
            this.checkedListBoxPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxPages.Name = "checkedListBoxPages";
            this.checkedListBoxPages.Size = new System.Drawing.Size(240, 140);
            this.checkedListBoxPages.TabIndex = 3;
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(264, 159);
            this.checkedListBoxGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(240, 140);
            this.checkedListBoxGroups.TabIndex = 4;
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Location = new System.Drawing.Point(15, 436);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(78, 17);
            this.labelAgeRange.TabIndex = 5;
            this.labelAgeRange.Text = "Age range:";
            // 
            // comboBoxMinAge
            // 
            this.comboBoxMinAge.FormattingEnabled = true;
            this.comboBoxMinAge.Location = new System.Drawing.Point(99, 436);
            this.comboBoxMinAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMinAge.Name = "comboBoxMinAge";
            this.comboBoxMinAge.Size = new System.Drawing.Size(45, 24);
            this.comboBoxMinAge.TabIndex = 6;
            // 
            // comboBoxMaxAge
            // 
            this.comboBoxMaxAge.FormattingEnabled = true;
            this.comboBoxMaxAge.Location = new System.Drawing.Point(169, 436);
            this.comboBoxMaxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMaxAge.Name = "comboBoxMaxAge";
            this.comboBoxMaxAge.Size = new System.Drawing.Size(45, 24);
            this.comboBoxMaxAge.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // buttonFindFriends
            // 
            this.buttonFindFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindFriends.Location = new System.Drawing.Point(587, 159);
            this.buttonFindFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindFriends.Name = "buttonFindFriends";
            this.buttonFindFriends.Size = new System.Drawing.Size(145, 33);
            this.buttonFindFriends.TabIndex = 9;
            this.buttonFindFriends.Text = "Find Friends";
            this.buttonFindFriends.UseVisualStyleBackColor = true;
            this.buttonFindFriends.Click += new System.EventHandler(this.buttonFindFriends_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "your team is:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(588, 306);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(201, 164);
            this.listBoxFriends.TabIndex = 11;
            // 
            // labelFriendsUpdate
            // 
            this.labelFriendsUpdate.AutoSize = true;
            this.labelFriendsUpdate.Location = new System.Drawing.Point(585, 202);
            this.labelFriendsUpdate.Name = "labelFriendsUpdate";
            this.labelFriendsUpdate.Size = new System.Drawing.Size(0, 17);
            this.labelFriendsUpdate.TabIndex = 12;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(23, 332);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(83, 60);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 14;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(20, 306);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(86, 17);
            likesCountLabel.TabIndex = 15;
            likesCountLabel.Text = "Likes Count:";
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Location = new System.Drawing.Point(125, 306);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
            this.likesCountLabel1.TabIndex = 16;
            this.likesCountLabel1.Text = "label4";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(264, 332);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(77, 60);
            this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox1.TabIndex = 17;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // FormFindTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.imageNormalPictureBox1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(likesCountLabel);
            this.Controls.Add(this.likesCountLabel1);
            this.Controls.Add(this.labelFriendsUpdate);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFindFriends);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaxAge);
            this.Controls.Add(this.comboBoxMinAge);
            this.Controls.Add(this.labelAgeRange);
            this.Controls.Add(this.checkedListBoxGroups);
            this.Controls.Add(this.checkedListBoxPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFeatureExplanation);
            this.Controls.Add(this.labelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFindTeam";
            this.Text = "FormFindTeam";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelFeatureExplanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPages;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroups;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.ComboBox comboBoxMinAge;
        private System.Windows.Forms.ComboBox comboBoxMaxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindFriends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriendsUpdate;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
    }
}
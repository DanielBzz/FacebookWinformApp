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
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(14, 30);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(280, 32);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Let\'s find your team";
            // 
            // labelFeatureExplanation
            // 
            this.labelFeatureExplanation.AutoSize = true;
            this.labelFeatureExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeatureExplanation.Location = new System.Drawing.Point(16, 86);
            this.labelFeatureExplanation.Name = "labelFeatureExplanation";
            this.labelFeatureExplanation.Size = new System.Drawing.Size(756, 40);
            this.labelFeatureExplanation.TabIndex = 1;
            this.labelFeatureExplanation.Text = "Discover your friends and open new group according common activities, like same g" +
    "roups and same\r\n pages\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose pages and groups:";
            // 
            // checkedListBoxPages
            // 
            this.checkedListBoxPages.FormattingEnabled = true;
            this.checkedListBoxPages.Location = new System.Drawing.Point(20, 198);
            this.checkedListBoxPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxPages.Name = "checkedListBoxPages";
            this.checkedListBoxPages.Size = new System.Drawing.Size(270, 193);
            this.checkedListBoxPages.TabIndex = 3;
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(297, 198);
            this.checkedListBoxGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(270, 193);
            this.checkedListBoxGroups.TabIndex = 4;
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Location = new System.Drawing.Point(17, 429);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(90, 20);
            this.labelAgeRange.TabIndex = 5;
            this.labelAgeRange.Text = "Age range:";
            // 
            // comboBoxMinAge
            // 
            this.comboBoxMinAge.FormattingEnabled = true;
            this.comboBoxMinAge.Location = new System.Drawing.Point(111, 429);
            this.comboBoxMinAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMinAge.Name = "comboBoxMinAge";
            this.comboBoxMinAge.Size = new System.Drawing.Size(51, 28);
            this.comboBoxMinAge.TabIndex = 6;
            // 
            // comboBoxMaxAge
            // 
            this.comboBoxMaxAge.FormattingEnabled = true;
            this.comboBoxMaxAge.Location = new System.Drawing.Point(191, 429);
            this.comboBoxMaxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMaxAge.Name = "comboBoxMaxAge";
            this.comboBoxMaxAge.Size = new System.Drawing.Size(51, 28);
            this.comboBoxMaxAge.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // buttonFindFriends
            // 
            this.buttonFindFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindFriends.Location = new System.Drawing.Point(660, 198);
            this.buttonFindFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindFriends.Name = "buttonFindFriends";
            this.buttonFindFriends.Size = new System.Drawing.Size(164, 42);
            this.buttonFindFriends.TabIndex = 9;
            this.buttonFindFriends.Text = "Find Friends";
            this.buttonFindFriends.UseVisualStyleBackColor = true;
            this.buttonFindFriends.Click += new System.EventHandler(this.buttonFindFriends_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "your team is:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(662, 321);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(226, 204);
            this.listBoxFriends.TabIndex = 11;
            // 
            // labelFriendsUpdate
            // 
            this.labelFriendsUpdate.AutoSize = true;
            this.labelFriendsUpdate.Location = new System.Drawing.Point(658, 253);
            this.labelFriendsUpdate.Name = "labelFriendsUpdate";
            this.labelFriendsUpdate.Size = new System.Drawing.Size(0, 20);
            this.labelFriendsUpdate.TabIndex = 12;
            // 
            // FormFindTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
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
    }
}
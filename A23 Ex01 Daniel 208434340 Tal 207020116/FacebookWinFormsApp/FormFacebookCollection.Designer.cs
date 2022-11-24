using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormFacebookCollection<T>
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

        private ListBox listBoxCollectionItemsNames;
        private TextBox textBoxSearchByName;
        private PictureBox pictureBoxItemMainPhoto;

        private void InitializeComponent()
        {
            this.listBoxCollectionItemsNames = new System.Windows.Forms.ListBox();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.pictureBoxItemMainPhoto = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.buttonShowPictures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCollectionItemsNames
            // 
            this.listBoxCollectionItemsNames.FormattingEnabled = true;
            this.listBoxCollectionItemsNames.Location = new System.Drawing.Point(12, 55);
            this.listBoxCollectionItemsNames.Name = "listBoxCollectionItemsNames";
            this.listBoxCollectionItemsNames.Size = new System.Drawing.Size(305, 316);
            this.listBoxCollectionItemsNames.TabIndex = 0;
            this.listBoxCollectionItemsNames.Click += new System.EventHandler(this.listBoxCollectionItemsNames_Click);
            this.listBoxCollectionItemsNames.SelectedIndexChanged += new System.EventHandler(this.listBoxCollectionItemsNames_SelectedIndexChanged);
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.AccessibleDescription = "";
            this.textBoxSearchByName.AccessibleName = "";
            this.textBoxSearchByName.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(305, 20);
            this.textBoxSearchByName.TabIndex = 1;
            this.textBoxSearchByName.Text = "Search";
            this.textBoxSearchByName.TextChanged += new System.EventHandler(this.textBoxSearchByName_TextChanged);
            // 
            // pictureBoxItemMainPhoto
            // 
            this.pictureBoxItemMainPhoto.Location = new System.Drawing.Point(323, 55);
            this.pictureBoxItemMainPhoto.Name = "pictureBoxItemMainPhoto";
            this.pictureBoxItemMainPhoto.Size = new System.Drawing.Size(124, 134);
            this.pictureBoxItemMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItemMainPhoto.TabIndex = 2;
            this.pictureBoxItemMainPhoto.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(324, 221);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(328, 254);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionValue.TabIndex = 4;
            // 
            // buttonShowPictures
            // 
            this.buttonShowPictures.Location = new System.Drawing.Point(327, 12);
            this.buttonShowPictures.Name = "buttonShowPictures";
            this.buttonShowPictures.Size = new System.Drawing.Size(115, 37);
            this.buttonShowPictures.TabIndex = 5;
            this.buttonShowPictures.Text = "Show all pictures in album";
            this.buttonShowPictures.UseVisualStyleBackColor = true;
            this.buttonShowPictures.Click += new System.EventHandler(this.buttonShowPictures_Click);
            // 
            // FormFacebookCollection
            // 
            this.ClientSize = new System.Drawing.Size(463, 389);
            this.Controls.Add(this.buttonShowPictures);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxItemMainPhoto);
            this.Controls.Add(this.textBoxSearchByName);
            this.Controls.Add(this.listBoxCollectionItemsNames);
            this.Name = "FormFacebookCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDescription;
        private Label labelDescriptionValue;
        private Button buttonShowPictures;
    }
}
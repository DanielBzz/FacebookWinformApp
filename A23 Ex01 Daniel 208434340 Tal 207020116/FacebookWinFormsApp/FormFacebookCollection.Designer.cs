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
            this.components = new System.ComponentModel.Container();
            this.listBoxCollectionItemsNames = new System.Windows.Forms.ListBox();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.pictureBoxItemMainPhoto = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.buttonShowPictures = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCollectionItemsNames
            // 
            this.listBoxCollectionItemsNames.FormattingEnabled = true;
            this.listBoxCollectionItemsNames.ItemHeight = 16;
            this.listBoxCollectionItemsNames.Location = new System.Drawing.Point(12, 55);
            this.listBoxCollectionItemsNames.Name = "listBoxCollectionItemsNames";
            this.listBoxCollectionItemsNames.Size = new System.Drawing.Size(305, 292);
            this.listBoxCollectionItemsNames.TabIndex = 0;
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.AccessibleDescription = "";
            this.textBoxSearchByName.AccessibleName = "";
            this.textBoxSearchByName.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(305, 22);
            this.textBoxSearchByName.TabIndex = 1;
            this.textBoxSearchByName.Text = "search";
            this.textBoxSearchByName.TextChanged += new System.EventHandler(this.textBoxSearchByName_TextChanged);
            this.textBoxSearchByName.Enter += new System.EventHandler(this.textBoxSearchByName_Enter);
            this.textBoxSearchByName.Leave += new System.EventHandler(this.textBoxSearchByName_Leave);
            // 
            // pictureBoxItemMainPhoto
            // 
            this.pictureBoxItemMainPhoto.Location = new System.Drawing.Point(323, 55);
            this.pictureBoxItemMainPhoto.Name = "pictureBoxItemMainPhoto";
            this.pictureBoxItemMainPhoto.Size = new System.Drawing.Size(124, 134);
            this.pictureBoxItemMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItemMainPhoto.TabIndex = 2;
            this.pictureBoxItemMainPhoto.TabStop = false;
            this.pictureBoxItemMainPhoto.Click += new System.EventHandler(this.pictureBoxItemMainPhoto_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(324, 221);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(328, 254);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(0, 17);
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
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // FormFacebookCollection
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(598, 389);
            this.Controls.Add(this.buttonShowPictures);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxItemMainPhoto);
            this.Controls.Add(this.textBoxSearchByName);
            this.Controls.Add(this.listBoxCollectionItemsNames);
            this.Name = "FormFacebookCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemMainPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDescription;
        private Label labelDescriptionValue;
        private Button buttonShowPictures;
        private BindingSource groupBindingSource;
    }
}
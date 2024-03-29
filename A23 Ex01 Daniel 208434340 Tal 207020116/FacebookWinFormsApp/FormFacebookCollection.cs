﻿using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFacebookCollection<T> : Form
    {
        private readonly GenericFacebookObjectCollection<T> r_FullCollection;
        private BindingList<T> m_InList;

        public FormFacebookCollection(GenericFacebookObjectCollection<T> i_Collection)
        {
            InitializeComponent();
            r_FullCollection = i_Collection;
            m_InList = new BindingList<T>();
            Text = $"{typeof(T).Name}s list";
            initialComponent();
            listBoxCollectionItemsNames.DataSource = m_InList;
            listBoxCollectionItemsNames.DisplayMember = "Name";
            listBoxCollectionItemsNames.Format += (sender, e) =>
                e.Value = typeof(T).GetProperty("Name").GetValue(e.ListItem) ?? "No Name for " + typeof(T).Name;
        }

        public void DescriptionDataBinding(string i_DataSourceDescriptionProperty)
        {
            labelDescriptionValue.DataBindings.Add(new Binding("Text", listBoxCollectionItemsNames.DataSource, i_DataSourceDescriptionProperty, true));
        }

        public void MainPhotoDataBinding(string i_DataSourceImageProperty)
        {
            pictureBoxItemMainPhoto.DataBindings.Add(new Binding("Image", listBoxCollectionItemsNames.DataSource, i_DataSourceImageProperty, true));
        }

        private void initialComponent()
        {
            foreach (T item in r_FullCollection)
            {
                   m_InList.Add(item);
            }

            buttonShowPictures.Visible = typeof(T) == typeof(Album);
        }

        private void buttonShowPictures_Click(object sender, EventArgs e)
        {
            if(listBoxCollectionItemsNames.SelectedIndex != -1)
            {
                FormFacebookCollection <Photo> form =
                    new FormFacebookCollection<Photo>(
                        new GenericFacebookObjectCollection<Photo>((m_InList[listBoxCollectionItemsNames.SelectedIndex] as Album).Photos));

                form.MainPhotoDataBinding("ImageNormal");
                form.ShowDialog();
            }
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Focused)
            {
                r_FullCollection.Strategy = new FilterByString<T>(textBoxSearch.Text);
                m_InList.Clear();
                foreach (T item in r_FullCollection)
                {
                        m_InList.Add(item);
                }
            }
        }

        private void textBoxSearchByName_Leave(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Text == string.Empty)
            {
                textBoxSearch.Text = "search";
            }
        }

        private void textBoxSearchByName_Enter(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Text.Equals("search"))
            {
                textBoxSearch.Text = string.Empty;
            }
        }

        private void pictureBoxItemMainPhoto_Click(object sender, EventArgs e)
        {
            PropertyInfo pictureProperty = typeof(T).GetProperty("PictureNormalURL");

            if (pictureProperty != null && listBoxCollectionItemsNames.SelectedIndex != -1)
            {
                new FormPicture(pictureProperty.GetValue(listBoxCollectionItemsNames.SelectedItem) as string).ShowDialog();
            }
        }
    }
}
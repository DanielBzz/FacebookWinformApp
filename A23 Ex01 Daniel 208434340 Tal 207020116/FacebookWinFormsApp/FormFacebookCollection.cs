using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace BasicFacebookFeatures
{
    public partial class FormFacebookCollection<T> : Form
    {

        private readonly FacebookObjectCollection<T> m_Collection;
        private List<T> m_InList;

        public FormFacebookCollection(FacebookObjectCollection<T> i_Collection)
        {
            m_Collection = i_Collection;
            m_InList = new List<T>(i_Collection.Count);
            InitializeComponent();
            initialComponent();
            Text = $"{typeof(T).Name}s list";
        }

        public void initialComponent()
        {
            PropertyInfo nameProperty = typeof(T).GetProperty("Name");

            foreach (T item in m_Collection)
            {
                string name = nameProperty.GetValue(item) is string ?
                    nameProperty.GetValue(item) as string : $"No name for {typeof(T).Name}";
                listBoxCollectionItemsNames.Items.Add(name);
                m_InList.Add(item);
            }

            if (m_Collection.Count == 0)
            {
                listBoxCollectionItemsNames.Items.Add($"No {typeof(T).Name}s to show");
                textBoxSearchByName.Enabled = false;
            }

            buttonShowPictures.Visible = typeof(T) == typeof(Album);
        }

        private void listBoxCollectionItemsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            initalMainPictureValue(listBoxCollectionItemsNames.SelectedIndex);
            initialDescriptionValue(listBoxCollectionItemsNames.SelectedIndex);
        }

        private void initalMainPictureValue(int selectedIndex)
        {
            PropertyInfo pictureProperty = typeof(T).GetProperty("PictureNormalURL");

            if (pictureProperty != null)
            {
                pictureBoxItemMainPhoto.LoadAsync(
                    pictureProperty.GetValue(m_InList[listBoxCollectionItemsNames.SelectedIndex]) as string);
            }
        }

        private void initialDescriptionValue(int i_indexInList)
        {
            PropertyInfo descriptionProperty = typeof(T).GetProperty("Description");

            if (descriptionProperty != null)
            {
                labelDescriptionValue.Text = descriptionProperty.GetValue(m_InList[i_indexInList]) as string;
            }
            else
            {
                labelDescription.Text = string.Empty;
            }
        }

        private void listBoxCollectionItemsNames_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = m_InList[listBoxCollectionItemsNames.SelectedIndex] as Album;

            if (selectedAlbum != null)
            {
                pictureBoxItemMainPhoto.LoadAsync(selectedAlbum.PictureAlbumURL);

            }
        }

        private void buttonShowPictures_Click(object sender, EventArgs e)
        {
            if(listBoxCollectionItemsNames.SelectedIndex != -1)
            {
                new FormFacebookCollection<Photo>((m_InList[listBoxCollectionItemsNames.SelectedIndex] as Album).Photos).ShowDialog();
            }
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Focused)
            {
                PropertyInfo nameProperty = typeof(T).GetProperty("Name");
                string currentName = null;

                listBoxCollectionItemsNames.Items.Clear();
                m_InList.Clear();
                foreach (T item in m_Collection)
                {
                    currentName = nameProperty.GetValue(item) is string ?
                        nameProperty.GetValue(item) as string : $"No name for {typeof(T).Name}";
                    if (currentName != null && currentName.ToUpper().Contains(textBoxSearchByName.Text.ToUpper()))
                    {
                        listBoxCollectionItemsNames.Items.Add(currentName);
                        m_InList.Add(item);
                    }
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
                new FormPicture(
                    pictureProperty.GetValue(m_InList[listBoxCollectionItemsNames.SelectedIndex]) as string).ShowDialog();
            }
        }
    }
}
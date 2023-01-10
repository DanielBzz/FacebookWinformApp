using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFindTeam : Form
    {
        private readonly FacebookEngineFacade r_FacebookEngineFacade;
        private User m_LoggedInUser;

        public FormFindTeam(User i_User, FacebookEngineFacade i_EngineSystemOperations)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            bindListBoxesToDataSource();
            r_FacebookEngineFacade = i_EngineSystemOperations;
            for (int i = 18; i < 100; i++)
            {
                comboBoxMinAge.Items.Add(i);
                comboBoxMaxAge.Items.Add(i);
            }
        }

        private void bindListBoxesToDataSource()
        {
            pageBindingSource.DataSource = m_LoggedInUser.LikedPages;
            (checkedListBoxPages as ListBox).DataSource = pageBindingSource;
            (checkedListBoxPages as ListBox).DisplayMember = "Name";
            groupBindingSource.DataSource = m_LoggedInUser.Groups;
            (checkedListBoxGroups as ListBox).DataSource = groupBindingSource;
            (checkedListBoxGroups as ListBox).DisplayMember = "Name";
        }

        private void buttonFindFriends_Click(object sender, EventArgs e)
        {
            labelFriendsUpdate.Text = string.Empty;
            if (comboBoxMaxAge.SelectedItem == null || comboBoxMinAge.SelectedItem == null)
            {
                MessageBox.Show("you should initial the age range boxes");
            }
            else if ((int)comboBoxMaxAge.SelectedItem < (int)comboBoxMinAge.SelectedItem)
            {
                MessageBox.Show("your minmum age choice is bigger than the maximum age choice");
            }
            else if (checkedListBoxGroups.CheckedItems.Count == 0 && checkedListBoxPages.CheckedItems.Count == 0)
            {
                MessageBox.Show("you should choose at least one item");
            }
            else
            {
                List<string> friendsNames = r_FacebookEngineFacade.GetMyTeam(
                    m_LoggedInUser,
                    checkedListBoxPages.CheckedItems.OfType<Page>(),
                    checkedListBoxGroups.CheckedItems.OfType<Group>(),
                    (int)comboBoxMinAge.SelectedItem,
                    (int)comboBoxMaxAge.SelectedItem);

                friendsNames.ForEach(item => listBoxFriends.Items.Add(item));
                if (friendsNames.Count == 0)
                {
                    labelFriendsUpdate.Text = "No friends are found";
                }
            }
        }
    }
}

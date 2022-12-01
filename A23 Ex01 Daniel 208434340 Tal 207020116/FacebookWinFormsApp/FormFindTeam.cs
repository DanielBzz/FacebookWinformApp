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
        private User m_LoggedInUser;
        private FindTeamLogic m_FindTeamLogic;

        public FormFindTeam(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            for (int i = 18; i < 100; i++)
            {
                comboBoxMinAge.Items.Add(i);
                comboBoxMaxAge.Items.Add(i);
            }

            initialLists();
            m_FindTeamLogic = new FindTeamLogic(m_LoggedInUser);
        }

        private void initialLists()
        {
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                checkedListBoxPages.Items.Add(page.Name);
            }

            foreach (Group group in m_LoggedInUser.Groups)
            {
                checkedListBoxGroups.Items.Add(group.Name);
            }
        }

        private void buttonFindFriends_Click(object sender, EventArgs e)
        {
            labelFriendsUpdate.Text = string.Empty;
            if (comboBoxMaxAge.SelectedItem == null || comboBoxMinAge.SelectedItem == null)
            {
                MessageBox.Show("you should initial the age range boxes");
            }
            else if((int)comboBoxMaxAge.SelectedItem < (int)comboBoxMinAge.SelectedItem)
            {
                MessageBox.Show("your minmum age choice is bigger than the maximum age choice");
            }
            else if (checkedListBoxGroups.CheckedItems.Count == 0 && checkedListBoxPages.CheckedItems.Count == 0)
            {
                MessageBox.Show("you should choose at least one item");
            }
            else
            {
                List<string> friendsNames = m_FindTeamLogic.FindFriendsInTeam(
                    checkedListBoxPages.CheckedItems.OfType<string>(),
                    checkedListBoxGroups.CheckedItems.OfType<string>(),
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

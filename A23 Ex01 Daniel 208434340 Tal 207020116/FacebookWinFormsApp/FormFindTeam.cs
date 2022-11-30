using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFindTeam : Form
    {
        private User m_LoggedInUser;

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
                findFriends();
            }
        }

        private void findFriends()
        {
            bool haveSamePages = false;
            bool haveSameGroups = false;
            int counter = 0;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                foreach (string pageName in checkedListBoxPages.CheckedItems)
                {
                    foreach (Page friendPage in friend.LikedPages)
                    {
                        counter = pageName.Equals(friendPage.Name) ? counter + 1 : counter;
                    }
                }

                haveSamePages = counter == checkedListBoxPages.CheckedItems.Count;
                counter = 0;
                foreach (string groupName in checkedListBoxGroups.CheckedItems)
                {
                    foreach (Group friendGroup in friend.Groups)
                    {
                        counter = groupName.Equals(friendGroup.Name) ? counter + 1 : counter;
                    }
                }

                haveSameGroups = counter == checkedListBoxGroups.CheckedItems.Count;
                counter = 0;

                if (haveSamePages && haveSameGroups && inAgeRange())
                {
                    listBoxFriends.Items.Add(friend.Name);
                }
            }
        }

        private bool inAgeRange()
        {
            bool inRange = false;
            DateTime time = DateTime.Now;

            try
            {
                DateTime userBirthday = DateTime.Parse(m_LoggedInUser.Birthday);

                int age = time.Year - userBirthday.Year;

                age = time.Month < userBirthday.Month ||
                    (time.Month == userBirthday.Month && time.Day < userBirthday.Day) ? age - 1 : age;
                inRange = age <= (int)comboBoxMaxAge.SelectedItem && age >= (int)comboBoxMinAge.SelectedItem;
            }
            catch (Exception)
            {
                inRange = false;
            }

            return inRange;
        }
    }
}

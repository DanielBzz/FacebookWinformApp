using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private static readonly string r_LikesLabelString = "Likes: {0}";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            isRememberLastUser();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "878533360263979",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                whenConnected();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void whenConnected()
        {
            Text = $"{m_LoggedInUser.Name}'s Profile";
            checkBoxRememberMe.Enabled = true;
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchCoverPhoto();
            fetchFriendsList();
            fetchPosts();
            fetchAbout();
            fetchGroups();
            fetchPages();
            fetchEvents();
            fetchCheckIns();
        }

        private void fetchCoverPhoto()
        {
            Album coverAlbum = m_LoggedInUser.Albums.Find(isCoverAlbum);

            if (coverAlbum != null)
            {
                pictureBoxCover.LoadAsync(coverAlbum.PictureAlbumURL);
            }
            else
            {
                string names = string.Empty;
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    names += Environment.NewLine + album.Name;
                }

                MessageBox.Show(names);
            }
        }

        private bool isCoverAlbum(Album i_album)
        {
            return i_album.Name.ToUpper().Equals("COVER PHOTOS") || i_album.Name.Equals("תמונות נושא");
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.CreatedTime + ": " + post.Message);
                }
            }
        }

        private void fetchFriendsList()
        {
            int numOfFriendsToShow = m_LoggedInUser.Friends.Count > 1 ?
                2 : m_LoggedInUser.Friends.Count;

            for (int i = 0; i < numOfFriendsToShow; i++)
            {
                listBoxFriends.Items.Add(m_LoggedInUser.Friends[0].UserName);
            }
        }

        private void fetchPages()
        {
            Random rand = new Random();
            int numOfPagesToShow = m_LoggedInUser.LikedPages.Count > 2 ?
                3 : m_LoggedInUser.Friends.Count;

            for (int i = 0; i < numOfPagesToShow; i++)
            {
                listBoxPages.Items.Add(m_LoggedInUser.LikedPages[rand.Next(0, m_LoggedInUser.LikedPages.Count)].Name);
            }
        }

        private void fetchEvents()
        {
            if (m_LoggedInUser.Events.Count == 0)
            {
                listBoxEvents.Items.Add("You don't have any upcoming events");
            }

            foreach (Event evnt in m_LoggedInUser.Events)
            {
                if (evnt.Name != null)
                {
                    listBoxEvents.Items.Add(evnt.Name + ": " + evnt.Description);
                }
            }
        }

        private void fetchAbout()
        {
            if (m_LoggedInUser.Name != null)
            {
                listBoxAbout.Items.Add("UserName: " + m_LoggedInUser.Name);
            }
            if (m_LoggedInUser.Email != null)
            {
                listBoxAbout.Items.Add("Email: " + m_LoggedInUser.Email);
            }
            if (m_LoggedInUser.Birthday != null)
            {
                listBoxAbout.Items.Add("Birthday: " + m_LoggedInUser.Birthday);
            }
            if (m_LoggedInUser.Hometown != null)
            {
                listBoxAbout.Items.Add("Hometown: " + m_LoggedInUser.Hometown);
            }
            if (m_LoggedInUser.Location != null)
            {
                listBoxAbout.Items.Add("Current location: " + m_LoggedInUser.Location);
            }
        }

        private void fetchCheckIns()
        {
            foreach (Checkin checkIn in m_LoggedInUser.Checkins)
            {
                if (checkIn.Name != null)
                {
                    listBoxCheckIns.Items.Add(checkIn.Name + ": " + checkIn.Description);
                }
            }
        }

        private void fetchGroups()
        {
            if (m_LoggedInUser.Groups.Count == 0)
            {
                listBoxGroups.Items.Add("You don't belong to any group");
            }

            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name != null)
                {
                    listBoxGroups.Items.Add(group.Name);
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
			checkBoxRememberMe.Checked = false;
			checkBoxRememberMe.Enabled = false;
        }

        private void isRememberLastUser()
        {
            UserDetails lastUser = UserDetails.LoadFromFile();

            if (lastUser.Remember)
            {
                m_LoginResult = FacebookService.Connect(lastUser.UserToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                whenConnected();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string token = checkBoxRememberMe.Checked ? m_LoginResult.AccessToken : null;
            new UserDetails(token).SaveToFile();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            labelCurrentPostLikes.Text = string.Format(r_LikesLabelString, selected.LikedBy.Count);
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            new FormFacebookCollection<User>(m_LoggedInUser.Friends).ShowDialog();
        }

        private void buttonShowAllPages_Click(object sender, EventArgs e)
        {
            new FormFacebookCollection<Page>(m_LoggedInUser.LikedPages).ShowDialog();
        }

        private void buttonShowAllGroups_Click(object sender, EventArgs e)
        {
            new FormFacebookCollection<Group>(m_LoggedInUser.Groups).ShowDialog();

        }

        private void buttonShowAllEvents_Click(object sender, EventArgs e)
        {
            new FormFacebookCollection<Event>(m_LoggedInUser.Events).ShowDialog();
        }
    }
}

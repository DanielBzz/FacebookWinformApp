using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookEngine;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private static readonly string rs_LikesLabelString = "Likes: {0}";
        private readonly Random r_Random = new Random();
        private bool m_RememberUser;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private FormFindTeam m_FormFindTeam = null;

        public bool LogoutPressed { get; set; }

        public FormMain(LoginResult i_LoginResult, bool i_RememberUser)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_RememberUser = i_RememberUser;
        }

        public void whenConnected()
        {
            Text = $"{m_LoggedInUser.Name}'s Profile";
            fetchUserInfo();
            timer1.Enabled = true;
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
            fetchAlbums();
        }

        private void fetchCoverPhoto()
        {
            Album coverAlbum = m_LoggedInUser.Albums.Find(isCoverAlbum);

            if (coverAlbum != null)
            {
                pictureBoxCover.LoadAsync(coverAlbum.PictureAlbumURL);
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

        private void fetchAlbums()
        {
            if (m_LoggedInUser.Albums.Count == 0)
            {
                listBoxAlbums.Items.Add("You don't have albums");
            }

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name != null)
                {
                    listBoxAlbums.Items.Add(album.Name + ": " + album.Description);
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
			m_RememberUser = false;
			LogoutPressed = true;
			Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string token = m_RememberUser ? m_LoginResult.AccessToken : null;
            new UserDetails(token).SaveToFile();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            // labelCurrentPostLikes.Text = string.Format(r_LikesLabelString, selected.LikedBy.Count); LikedBy throw exception!
            labelCurrentPostLikes.Text = string.Format(rs_LikesLabelString, 1);
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

        private void buttonShowAllAlbums_Click(object sender, EventArgs e)
        {
            new FormFacebookCollection<Album>(m_LoggedInUser.Albums).ShowDialog();
        }

        private void changeRandomPictureInPictureBox()
        {
            Album selectedRandomAlbum = m_LoggedInUser.Albums[r_Random.Next(0, m_LoggedInUser.Albums.Count)];
            Photo selectedRandomPhoto = null;

            if(selectedRandomAlbum != null)
            {
                if (selectedRandomAlbum.Photos.Count > 0)
                {
                    selectedRandomPhoto = selectedRandomAlbum.Photos[r_Random.Next(0, selectedRandomAlbum.Photos.Count)];
                    if (selectedRandomPhoto != null)
                    {
                        pictureBoxChange.LoadAsync(selectedRandomPhoto.PictureNormalURL);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeRandomPictureInPictureBox();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            new FormPicture((sender as PictureBox)?.Image).ShowDialog();
        }

        private void buttonFindFriends_Click(object sender, EventArgs e)
        {
            if (m_FormFindTeam == null)
            {
                m_FormFindTeam = new FormFindTeam(m_LoggedInUser);
            }

            m_FormFindTeam.ShowDialog();
        }
    }
}

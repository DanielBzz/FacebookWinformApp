using System;
using System.Threading;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private static readonly string rs_LikesLabelString = "Likes: {0}";
        private readonly Random r_Random = new Random();
        private readonly FacebookEngineFacade r_FacebookEngineFacade;
        private bool m_RememberUser;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private FormFindTeam m_FormFindTeam = null;

        public bool LogoutPressed { get; set; }

        public FormMain(LoginResult i_LoginResult, bool i_RememberUser, FacebookEngineFacade i_SystemEngineFacade)
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_RememberUser = i_RememberUser;
            r_FacebookEngineFacade = i_SystemEngineFacade;
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
            fetchAbout();
            new Thread(() =>
            {
                fetchCoverPhoto();
                fetchAlbums();
            }).Start();
            new Thread(() => fetchFriendsList()).Start();
            new Thread(() => fetchPosts()).Start();
            new Thread(() => fetchGroups()).Start();
            new Thread(() => fetchPages()).Start();
            new Thread(() => fetchEvents()).Start();
        }

        private void fetchCoverPhoto()
        {
            Album coverAlbum = m_LoggedInUser.Albums.Find(isCoverAlbum);

            if (coverAlbum != null)
            {
                pictureBoxCover.Invoke(new Action(() => pictureBoxCover.LoadAsync(coverAlbum.PictureAlbumURL)));
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
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.CreatedTime + ": " + post.Message)));
                }
            }
        }

        private void fetchFriendsList()
        {
            int numOfFriendsToShow = m_LoggedInUser.Friends.Count > 1 ?
                2 : m_LoggedInUser.Friends.Count;

            for (int i = 0; i < numOfFriendsToShow; i++)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(m_LoggedInUser.Friends[0].UserName)));
            }
        }

        private void fetchPages()
        {
            Random rand = new Random();
            int numOfPagesToShow = m_LoggedInUser.LikedPages.Count > 2 ?
                3 : m_LoggedInUser.Friends.Count;

            for (int i = 0; i < numOfPagesToShow; i++)
            {
                listBoxPages.Invoke(new Action(
                    () => listBoxPages.Items.Add(m_LoggedInUser.LikedPages[rand.Next(0, m_LoggedInUser.LikedPages.Count)].Name)));
            }
        }

        private void fetchEvents()
        {
            if (m_LoggedInUser.Events.Count == 0)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add("You don't have any upcoming events")));
            }

            foreach (Event evnt in m_LoggedInUser.Events)
            {
                if (evnt.Name != null)
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(evnt.Name + ": " + evnt.Description)));
                }
            }
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name != null)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album.Name + ": " + album.Description)));
                }
            }
        }

        private void fetchAbout()
        {
            foreach (string info in r_FacebookEngineFacade.GetDetailsAboutUser(m_LoggedInUser))
            {
                    listBoxAbout.Items.Add(info);
            }
        }

        private void fetchGroups()
        {
            if (m_LoggedInUser.Groups.Count == 0)
            {
                listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add("You don't belong to any group")));
            }

            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name != null)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group.Name)));
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			m_RememberUser = false;
			LogoutPressed = true;
			timer1.Stop();
			Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string token = m_RememberUser ? m_LoginResult.AccessToken : null;

            r_FacebookEngineFacade.rememberUserForNextTime(token);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            labelCurrentPostLikes.Text = string.Format(rs_LikesLabelString, 1);
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.FriendsForm).ShowDialog();
        }

        private void buttonShowAllPages_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.LikedPagesForm).ShowDialog();
        }

        private void buttonShowAllGroups_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.GroupsForm).ShowDialog();
        }

        private void buttonShowAllEvents_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.EventsForm).ShowDialog();
        }

        private void buttonShowAllAlbums_Click(object sender, EventArgs e)
        {
            CollectionFormFactory.CreateForm(m_LoggedInUser, eCollectionFormType.AlbumsForm).ShowDialog();
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
            new Thread(() => changeRandomPictureInPictureBox()).Start();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            new FormPicture((sender as PictureBox)?.Image).ShowDialog();
        }

        private void buttonFindFriends_Click(object sender, EventArgs e)
        {
            if (m_FormFindTeam == null)
            {
                m_FormFindTeam = new FormFindTeam(m_LoggedInUser, r_FacebookEngineFacade);
            }

            m_FormFindTeam.ShowDialog();
        }
    }
}

﻿using System;
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
                fetchUserInfo();
                buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void isRememberLastUser()
        {
            UserDetails lastUser = UserDetails.LoadFromFile();

            if (lastUser.Remember)
            {
                m_LoginResult = FacebookService.Connect(lastUser.UserToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchCoverPhoto();
            // should call here to the cover load , but it throw exception that the Cover property dont have offset_y
            fetchCoverPhoto();
            fetchFriendsList();
           // fetchPosts();
            fetchAbout();
            fetchGroups();
            fetchPages();
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
            return i_album.Name.Equals("Cover photos");
        }
        private bool isProfileAlbum(Album i_album)
        {
            return i_album.Name.Equals("Profile pictures");
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
            try
            {
                int numOfFriendsToShow = m_LoggedInUser.Friends.Count > 1 ?
                    2 : m_LoggedInUser.Friends.Count;

                for (int i = 0; i < numOfFriendsToShow; i++)
                {
                    listBoxFriends.Items.Add(m_LoggedInUser.Friends[0].UserName);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "     " + e.StackTrace);
            }
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            // some logic that open new form with list of all the user friends
            // and search line for specific friens
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string token = checkBoxRememberMe.Checked ? m_LoginResult.AccessToken : null;
            new UserDetails(token).SaveToFile();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            //labelCurrentPostLikes.Text = string.Format(r_LikesLabelString, selected.LikedBy.Count);
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void fetchGroups()
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name != null)
                {
                    listBoxGroups.Items.Add(group.Name + ": " + group.Description);
                }
            }
        }

        private void fetchPages()
        {
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                if (page.Name != null)
                {
                    listBoxPages.Items.Add(page.Name + ": " + page.Description);
                }
            }
        }
       
        /*
        Album pageAlbum = page.Albums.Find(isPageAlbum);
                if (pageAlbum != null)
                {
                    pictureBoxCover.LoadAsync(pageAlbum.PictureAlbumURL);
                }*/

    private void fetchEvents()
        {
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
            if (m_LoggedInUser.UserName != null)
            {
                listBoxAbout.Items.Add("UserName: " + m_LoggedInUser.UserName);
            }
            if (m_LoggedInUser.Email != null)
            {
                listBoxAbout.Items.Add("Email: " + m_LoggedInUser.Email);
            }
            if (m_LoggedInUser.Birthday != null)
            {
                listBoxAbout.Items.Add("Birthday: " + m_LoggedInUser.Birthday);
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
    }
}
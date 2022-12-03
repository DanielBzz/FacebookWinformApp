using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private FormMain m_MainApp;

        public FormMain MainApp
        {
            get
            {
                return m_MainApp;
            }
        }

        public FormLogin()
        {
            InitializeComponent();
            checkIfRememberLastUser();
        }

        public bool isUserConnected()
        {
            return m_MainApp != null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult loginResult = FacebookService.Login(
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
                    "user_videos",
                    "groups_access_member_info");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                initialMainApp(loginResult);
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
        }

        private void checkIfRememberLastUser()
        {
            UserDetails lastUser = UserDetails.LoadFromFile();

            if (lastUser.Remember)
            {
                LoginResult loginResult = FacebookService.Connect(lastUser.m_UserToken);
                checkBoxRememberMe.Checked = true;
                initialMainApp(loginResult);
            }
        }

        private void initialMainApp(LoginResult i_LoginResult)
        {
            m_MainApp = new FormMain(i_LoginResult, checkBoxRememberMe.Checked);
            m_MainApp.whenConnected();
            Close();
        }
    }
}

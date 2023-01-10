using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin loginForm;

            do
            {
                loginForm = new FormLogin();

                if (!loginForm.isUserConnected())
                {
                    Application.Run(loginForm);
                }

                if (loginForm.isUserConnected())
                {
                    loginForm.MainApp.ShowDialog();
                }
            }
            while (loginForm.MainApp != null && loginForm.MainApp.LogoutPressed);
        }
    }
}

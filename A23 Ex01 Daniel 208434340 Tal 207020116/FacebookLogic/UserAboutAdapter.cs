using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacebookEngine
{
    internal class UserAboutAdapter : IAbout
    {
        private readonly User r_User;

        public UserAboutAdapter(User i_User)
        {
            r_User = i_User;
        }

        public List<string> AboutUser()
        {
            List<string> detailsAbuotUser = new List<string>();

            foreach (PropertyInfo property in typeof(User).GetProperties())
            {
                if (property.PropertyType == typeof(string) && !property.Name.Contains("URL") && property.GetValue(r_User) != null) 
                {
                    detailsAbuotUser.Add(property.Name + ": " + property.GetValue(r_User));
                }
            }

            return detailsAbuotUser;
        }
    }
}

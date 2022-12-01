using System;
using System.IO;
using System.Xml.Serialization;

namespace FacebookEngine
{
    public class UserDetails
    {
        private const string k_FileName = "userDetails.xml";
        private static string r_FilePath = Path.Combine(Environment.CurrentDirectory, k_FileName);
        public string UserToken { get; }

        public UserDetails(string i_Token)
        {
            UserToken = i_Token;
        }

        private UserDetails()
        {
            UserToken = null;
        }

        public bool Remember
        {
            get
            {
                return UserToken != null;
            }
        }

        public static UserDetails LoadFromFile()
        {
            UserDetails lastUser = null;
            Stream stream = null;

            try
            {
                stream = new FileStream(r_FilePath, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(UserDetails));
                lastUser = serializer.Deserialize(stream) as UserDetails;
            }
            catch (Exception)
            {
                lastUser = new UserDetails();
            }
            finally
            {
                stream?.Dispose();
            }

            return lastUser;
        }

        public void SaveToFile()
        {
            FileMode mode = File.Exists(r_FilePath) ?
                FileMode.Truncate : FileMode.Create;

            using (Stream stream = new FileStream(r_FilePath, mode))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
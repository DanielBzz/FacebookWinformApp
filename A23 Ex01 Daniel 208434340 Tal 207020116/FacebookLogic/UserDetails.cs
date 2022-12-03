using System;
using System.IO;
using System.Xml.Serialization;

namespace FacebookEngine
{
    public class UserDetails
    {
        private const string k_FileName = "userDetails.xml";
        private static readonly  string sr_FilePath = Path.Combine(Environment.CurrentDirectory, k_FileName);
        public string m_UserToken;

        public UserDetails(string i_Token)
        {
            m_UserToken = i_Token;
        }

        private UserDetails()
        {
            m_UserToken = null;
        }

        public bool Remember
        {
            get
            {
                return m_UserToken != null;
            }
        }

        public static UserDetails LoadFromFile()
        {
            UserDetails lastUser = null;
            Stream stream = null;

            try
            {
                stream = new FileStream(sr_FilePath, FileMode.Open);
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
            FileMode mode = File.Exists(sr_FilePath) ?
                FileMode.Truncate : FileMode.Create;

            using (Stream stream = new FileStream(sr_FilePath, mode))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
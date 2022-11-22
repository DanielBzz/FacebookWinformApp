using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    internal class UserDetails
    {
        private readonly string m_Token;

        private UserDetails()
        {
            m_Token = null;
        }

        public UserDetails(string token)
        {
            m_Token = token;
        }

        public bool Remember
        {
            get
            {
                return m_Token != null;
            }
        }

        public string UserToken
        {
            get
            {
                return m_Token;
            }
        }

        public static UserDetails LoadFromFile()
        {
            UserDetails lastUser = null;
            Stream stream = null;

            try
            {
                stream = new FileStream(@"C:/Temp/userDetails.xml", FileMode.Open);
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
            string filePath = @"C:/Temp/userDetails.xml";
            FileMode mode = File.Exists(filePath) ?
                FileMode.Truncate : FileMode.Create;

            using (Stream stream = new FileStream(filePath, mode))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
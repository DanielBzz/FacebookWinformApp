using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacebookEngine
{
    internal class FindTeamLogic
    {
        private User m_LoggedInUser;

        public FindTeamLogic(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public List<string> FindFriendsInTeam(IEnumerable<string> i_PagesChoices, IEnumerable<string> i_GroupsChoices, int i_MinAge, int i_MaxAge)
        {
            bool isHaveSamePagesAndGroups = false;
            int samePagesAndGroupsCounter = 0;
            List<string> friendsList = new List<string>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                foreach (string pageName in i_PagesChoices)
                {
                    foreach (Page friendPage in friend.LikedPages)
                    {
                        samePagesAndGroupsCounter = pageName.Equals(friendPage.Name) ?
                            samePagesAndGroupsCounter + 1 : samePagesAndGroupsCounter;
                    }
                }

                foreach (string groupName in i_GroupsChoices)
                {
                    foreach (Group friendGroup in friend.Groups)
                    {
                        samePagesAndGroupsCounter = groupName.Equals(friendGroup.Name) ?
                            samePagesAndGroupsCounter + 1 : samePagesAndGroupsCounter;
                    }
                }

                isHaveSamePagesAndGroups = samePagesAndGroupsCounter == i_GroupsChoices.Count() + i_PagesChoices.Count();
                if (isHaveSamePagesAndGroups && inAgeRange(i_MinAge,i_MaxAge))
                {
                    friendsList.Add(friend.Name);
                }
            }

            return friendsList;
        }

        private bool inAgeRange(int i_MinAge, int i_MaxAge)
        {
            bool inRange = false;
            DateTime time = DateTime.Now;

            try
            {
                DateTime userBirthday = DateTime.Parse(m_LoggedInUser.Birthday);
                int age = time.Year - userBirthday.Year;

                age = time.Month < userBirthday.Month ||
                    (time.Month == userBirthday.Month && time.Day < userBirthday.Day) ? age - 1 : age;
                inRange = age <= i_MaxAge && age >= i_MinAge;
            }
            catch (Exception)
            {
                inRange = false;
            }

            return inRange;
        }
    }
}

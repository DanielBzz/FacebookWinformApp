using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookEngine
{
    public class FacebookEngineFacade
    {
        private FindTeamLogic m_FindTeamLogic;
        private IAbout m_AboutUserAdapter;

        public List<string> GetMyTeam(User i_userInSystem, IEnumerable<Page> i_ChosenPages, IEnumerable<Group> i_ChosenGroups, int i_MinAge, int i_MaxAge)
        {
            if (m_FindTeamLogic == null)
            {
                m_FindTeamLogic = new FindTeamLogic(i_userInSystem);
            }

            List<string> chosenPagesNames = new List<string>();
            List<string> chosenGroupNames = new List<string>();

            foreach (Page page in i_ChosenPages)
            {
                chosenPagesNames.Add(page.Name);
            }

            foreach (Group group in i_ChosenGroups)
            {
                chosenGroupNames.Add(group.Name);
            }

            return m_FindTeamLogic.FindFriendsInTeam(chosenPagesNames, chosenGroupNames, i_MinAge, i_MaxAge);
        }

        public List<string> GetDetailsAboutUser(User i_userInSystem)
        {
            if (m_AboutUserAdapter == null)
            {
                m_AboutUserAdapter = new UserAboutAdapter(i_userInSystem);
            }

            return m_AboutUserAdapter.AboutUser();
        }

        public void rememberUserForNextTime(string i_Token)
        {
            new UserDetails(i_Token).SaveToFile();
        }

        public string GetRememberedUser()
        {
            return UserDetails.LoadFromFile().m_UserToken;
        }
    }
}

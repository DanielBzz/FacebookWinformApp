using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookEngine
{
    public class FacebookEngineFacade
    {
        private FindTeamLogic m_FindTeamLogic;
        private UserAboutAdapter r_AboutUserAdapter;

        public List<string> GetMyTeam(User i_userInSystem, IEnumerable<Page> chosenPages, IEnumerable<Group> chosenGroups, int minAge, int maxAge)
        {
            if (m_FindTeamLogic == null) {
                m_FindTeamLogic = new FindTeamLogic(i_userInSystem);
            }

            List<string> chosenPagesNames = new List<string>();
            List<string> chosenGroupNames = new List<string>();

            foreach (Page page in chosenPages)
            {
                chosenPagesNames.Add(page.Name);
            }

            foreach (Group group in chosenGroups)
            {
                chosenGroupNames.Add(group.Name);
            }

            return m_FindTeamLogic.FindFriendsInTeam(chosenPagesNames, chosenGroupNames, minAge, maxAge);
        }

        public List<string> GetDetailsAboutUser(User i_userInSystem)
        {
            if (r_AboutUserAdapter == null)
            {
                r_AboutUserAdapter = new UserAboutAdapter(i_userInSystem);
            }

            return r_AboutUserAdapter.AboutUser();
        }

        public void rememberUserForNextTime(string i_Token)
        {
            new UserDetails(i_Token).SaveToFile();
        }

        public string GetUserRemembered()
        {
            return UserDetails.LoadFromFile().m_UserToken;
        }
    }
}

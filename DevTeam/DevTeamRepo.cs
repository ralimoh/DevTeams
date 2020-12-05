using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam
{
    class DevTeamRepo
    {
        private List<DevTeamPoco> _listOfDevTeam = new List<DevTeamPoco>();

        //create
        public void AddDevTeamToList(DevTeamPoco devTeam)
        {
            _listOfDevTeam.Add(devTeam);
        }

        //Read
        public List<DevTeamPoco> GetContentList()
        {
            return _listOfDevTeam;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, DevTeamPoco newContent)
        {
            // Find the content
            DevTeamPoco oldContent = GetDevTeamByTitle(originalTitle);

            //Update the content
            if (oldContent != null)
            {
                oldContent.TeamName = newContent.TeamName;
                oldContent.TeamID = newContent.TeamID;

                return true;
            }
            else
            {
                return false;
            }
        }




        //Delete
        public bool RemoveContentFromList(string TeamName)
        {
            DevTeamPoco team = GetDevTeamByTitle(TeamName);
            bool results = _listOfDevTeam.Remove(team);
            return results;




        }

        //Drew's mini lesson about how c# works
        //DevTeamPoco devTeam = cool;
        //Person richmond = cool;
        //Person casey = funny;
        //Person drew = goofy; 


        //Helper method
        private DevTeamPoco GetDevTeamByTitle(string TeamName)
        {
            foreach (DevTeamPoco devTeam in _listOfDevTeam)
            {
                if (devTeam.TeamName.ToLower() == TeamName.ToLower())
                {
                    return devTeam;
                }
            }

            return null;
        }
    }
}

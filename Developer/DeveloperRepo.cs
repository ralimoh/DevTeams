using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class DeveloperRepo
    {
        private readonly List<DeveloperPoco> _developerDirectory = new List<DeveloperPoco>();

      
       

        //create
        public void AddDeveloperToList(DeveloperPoco developer)
        {
            _developerDirectory.Add(developer);
        }

        //Read
        public List<DeveloperPoco> GetContentList()
        {
            return _developerDirectory;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, DeveloperPoco newdeveloper)
        {
            // Find the content
            DeveloperPoco olddeveloper = GetContentByTitle(originalTitle);

            //Update the content
            if ( olddeveloper!= null)
            {
                olddeveloper.Name = newdeveloper.Name;
                olddeveloper.ID = newdeveloper.ID;

                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveContentFromList(string TeamID)
        {
            DeveloperPoco team = GetContentByTitle(TeamID);
            bool results = _developerDirectory.Remove(team);
            return results;




        }



        //Helper method
        private DeveloperPoco GetContentByTitle(string DeveloperName)
        {
            foreach (DeveloperPoco developer in _developerDirectory)
            {
                if (developer.Name.ToLower() == DeveloperName.ToLower())
                {
                    return developer;
                }
            }

            return null;
        }
    }
}

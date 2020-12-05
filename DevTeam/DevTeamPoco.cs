using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam
{
    public class DevTeamPoco
    {
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public List<DeveloperPoco> DeveloperList {get; set; }

    }
}


 
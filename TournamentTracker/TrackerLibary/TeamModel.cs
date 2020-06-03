using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
    public class TeamModel : Context
    {
        /// <summary>
        /// Represent the ID of each team
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represent a list of PersonModel on each team 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represent the the TeamName of each team
        /// </summary>
        public string TeamName { get; set; }
    }
}

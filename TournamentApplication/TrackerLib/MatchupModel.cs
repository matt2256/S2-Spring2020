using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
    public class MatchupModel : Context
    {
        #region Properties for MatchupModel
        /// <summary>
        /// Represent the ID of the Match
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represent the list of teams entred 
        /// in the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represent each team
        /// </summary>
        public TeamModel teamModel { get; set; }

        /// <summary>
        /// Represents each matchup rounds
        /// </summary>
        public int MatchupRound { get; set; }
        #endregion
    }
}

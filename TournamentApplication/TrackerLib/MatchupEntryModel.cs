using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
    public class MatchupEntryModel : Context
    {
        #region properties for MatchupEntryModel
        /// <summary>
        /// Represent the ID for one team in the matchup
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score of this team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup that this team 
        /// came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        #endregion
    }
}

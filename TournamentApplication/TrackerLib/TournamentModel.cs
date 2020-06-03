using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
    public class TournamentModel : Context
    {
        #region Fields
        /// <summary>
        /// Represent a non changeable variable for TournamentName
        /// </summary>
        private string _TournamentName;
        #endregion

        #region Properties for TournamenModel
        /// <summary>
        /// Represent the ID of each Tournament
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represent the name of each tournament
        /// </summary>
        public string TournamentName {
            get { return _TournamentName; }
            set { }
        }

        /// <summary>
        /// Represnt a list of TeamModel of entered 
        /// team in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represent a list in a list of each MatchupModel 
        /// to hold Rounds
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        #endregion
    }
}

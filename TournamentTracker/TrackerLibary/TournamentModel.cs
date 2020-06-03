using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public class TournamentModel
    {
        public int ID { get; set; }
        public string TournamentName { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}

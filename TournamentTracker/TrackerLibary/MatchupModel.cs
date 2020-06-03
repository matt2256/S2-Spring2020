using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public class MatchupModel
    {
        public int ID { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel teamModel { get; set; }
        public int MatchupRound { get; set; }
    }
}

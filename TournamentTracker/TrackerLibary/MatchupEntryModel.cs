using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public class MatchupEntryModel
    {
        public int ID { get; set; }
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}

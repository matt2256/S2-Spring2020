using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotPlayerCheck
{
    class RiotInfo
    {
        //Class for GET request for summonerInformation
        public class SummonerInfo
        {
            public string id { get; set; }
            public string accountid { get; set; }
            public string puuid { get; set; }
            public string name { get; set; }
            public int profileIconId { get; set; }
            public int revisionDate { get; set; }
            public int summonerLevel { get; set; }

        }

        //Class for GET request for League of Legends profile
        public class LeagueProfile
        {
            public string leagueId { get; set; }
            public string summonerId { get; set; }
            public string summonerName { get; set; }
            public string queueType { get; set; }
            public string tier { get; set; }
            public string rank { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public bool hotStreak { get; set; }
            public bool veteran { get; set; }
            public bool freshBlood { get; set; }
            public bool inactive { get; set; }
        }


        //Root Class
        public class RootSummonerInfo
        {
            public string name { get; set; }
            public string id { get; set; }
        }

        public class RootLeagueProfile
        {
            public string summonerName { get; set; }
            public string tier { get; set; }
            public string rank { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }

        }

    }
}

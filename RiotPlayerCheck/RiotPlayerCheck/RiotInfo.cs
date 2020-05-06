using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotPlayerCheck
{
    class RiotInfo
    {
        public class info
        {
            public string id { get; set; }
            public string accountid { get; set; }
            public string puuid { get; set; }
            public string name { get; set; }
            public int profileIconId { get; set; }
            public int revisionDate { get; set; }
            public int summonerLevel { get; set; }

        }

        public class Root
        {
            public string name { get; set; }
            public string id { get; set; }

        }

    }
}

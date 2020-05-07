using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotPlayerCheck
{
    //Bruges til at lave en ny object profil
    public class LeagueProfile
    {
        public string summonerName { get; set; }
        public string tier { get; set; }
        public string rank { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }


        public LeagueProfile(string SummonerName, string Tier, string Rank, int Wins, int Losses)
        {
            summonerName = SummonerName;
            tier = Tier;
            rank = Rank;
            wins = Wins;
            losses = Losses;
        }
    }
}

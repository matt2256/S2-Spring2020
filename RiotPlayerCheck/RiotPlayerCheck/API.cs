using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace RiotPlayerCheck
{
    public class API
    {

        #region Methoder

        //PlayerCheck
        public static void PlayerNameCheck(string name)
        {
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(string.Format($"https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key=RGAPI-49193e82-e6dc-4325-bb98-acfbc6aec99e"));

                RiotInfo.RootSummonerInfo output = JsonConvert.DeserializeObject<RiotInfo.RootSummonerInfo>(json);

                //Summoner name
                string.Format($"{output.name}");

                MessageBox.Show("Spiller navnet findes");
            }
        }

        //PlayerID
        public static void PlayerId(string name)
        {
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(string.Format($"https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key=RGAPI-49193e82-e6dc-4325-bb98-acfbc6aec99e"));

                RiotInfo.RootSummonerInfo output = JsonConvert.DeserializeObject<RiotInfo.RootSummonerInfo>(json);

            }
        }


        //PlayerInformation
        public static void PlayerInformation()
        {

        }
        #endregion
    }
}

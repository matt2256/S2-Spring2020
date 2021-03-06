﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace TrackerLib
{
    public class MatchupModel
    {
        #region Fields
        /// <summary>
        /// Represent a non changeable variable for MatchupRounds
        /// </summary>
        private int _MatchupRounds;
        #endregion

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
        public int MatchupRound { 
            get { return _MatchupRounds; } 
            set 
            {
                try
                {

                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine($"The number of rounds is higher than 10.{e}");
                    throw;
                }
            }
        }
        #endregion
    }
}

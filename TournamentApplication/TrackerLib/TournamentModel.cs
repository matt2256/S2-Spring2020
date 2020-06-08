using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackerLib
{
    public class TournamentModel
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
        [Key]
        [Column("Id")]
        public int ID { get; set; }

        /// <summary>
        /// Represent the name of each tournament
        /// </summary>
        [MaxLength(100)]
        [Column("Tournament Name")]
        [Required]
        public string TournamentName {
            get { return _TournamentName; }
            set 
            {
                try
                {

                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine($"The input is higher than 100 characters. {e}");
                    throw;
                }
            }
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

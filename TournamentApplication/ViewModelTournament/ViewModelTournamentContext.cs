using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrackerLib;

namespace ViewModelTournament
{
    class ViewModelTournamentContext : DbContext
    {
        /// <summary>
        /// Represent a empty constructor
        /// </summary>
        public ViewModelTournamentContext(){}


        #region dbset properties 
        /// <summary>
        /// Represent a dbset<> property of PersonModel
        /// </summary>
        public DbSet<PersonModel> Person { get; set; }

        /// <summary>
        /// Represent a dbset<> property of MatchupModel
        /// </summary>
        public DbSet<MatchupModel> Matchup { get; set; }

        /// <summary>
        /// Represent a dbset<> property of MachtupEntryModel
        /// </summary>
        public DbSet<MatchupEntryModel> MatchupEntries { get; set; }

        /// <summary>
        /// Represent a dbset<> property of TeamModel
        /// </summary>
        public DbSet<TeamModel> Team { get; set; }

        /// <summary>
        /// Represent a dbset<> property or TournamentModel
        /// </summary>
        public DbSet<TournamentModel> Tournament { get; set; }
        #endregion


    }
}

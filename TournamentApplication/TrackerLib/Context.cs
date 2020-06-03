using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace TrackerLib
{
    public class Context : DbContext
    {
        /// <summary>
        /// Represebt a enpty constructor
        /// </summary>
        public Context() { }

        #region ContextMethods
        /// <summary>
        /// Represent the config file for entity framework core 
        /// </summary>
        /// <param name="optionsBuilder">
        /// Represents the connecting string used for sql connection 
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=./CV-BB-5965;Database=Tournament");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        #endregion


        #region Entities
        /// <summary>
        /// Represents the table being quering
        /// </summary>
        public DbSet<MatchupEntryModel> MatchupEntryModels { get; set; }

        /// <summary>
        /// Represents the table being quering
        /// </summary>
        public DbSet<MatchupModel> MatchupModels { get; set; }

        /// <summary>
        /// Represents the table being quering
        /// </summary>
        public DbSet<PersonModel> PersonModels { get; set; }
       
        /// <summary>
        /// Represents the table being quering
        /// </summary>
        public DbSet<TeamModel> TeamModels { get; set; }

        /// <summary>
        /// Represents the table being quering
        /// </summary>
        public DbSet<TournamentModel> TournamentModels { get; set; }
        #endregion

    }
}

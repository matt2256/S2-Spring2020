using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TrackerLib
{
    [Table("People")]
   public class PersonModel
    {
        #region Fields
        private string _FirstName;
        #endregion

        #region Properties for PersonModel
        /// <summary>
        /// Represent ID of this person
        /// </summary>
        [Key]
        [Column("Id")]
        public int ID { get; set; }

        /// <summary>
        /// Represent the first name of this Person
        /// </summary>
        [MaxLength(20)]
        [Column("First Name")]
        [Required]
        public String FirstName
        {
            get { return _FirstName; }
            set
            {
                try
                {

                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine($"Your fist name is longer than 50 characters. {e}");
                    throw;
                } 
            }
        }
        /// <summary>
        /// Represent the last name of this Person
        /// </summary>
        [MaxLength(50)]
        [Column("Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Represent the in game of this person
        /// </summary>
        [MaxLength(100)]
        [Column("In game name")]
        [Required]
        public string PlayerName { get; set; }


        //MABY USED FOR FOREIGN KEY!!=!=! IDK 
        public ICollection<TeamModel> teamModels { get; set; }
        #endregion
    }
}

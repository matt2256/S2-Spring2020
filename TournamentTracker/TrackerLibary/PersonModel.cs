using System;
using System.Collections.Generic;
using System.Text;


namespace TrackerLibary
{
    public class PersonModel : DbContext
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Represent the first name of each Person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represent the last name of each Person
        /// </summary>
        public string LastName { get; set; }
    }
}

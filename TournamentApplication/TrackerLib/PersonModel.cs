using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
   public class PersonModel : Context
    {
        /// <summary>
        /// Represent ID of each person
        /// </summary>
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

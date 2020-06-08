using System;
using System.Collections.Generic;

using System.Text;


namespace TrackerLib
{
   public class PersonModel
    {
        #region Fields
        /// <summary>
        /// Represents a non changeable variable for FirstName
        /// </summary>
        private string _FirstName;

        /// <summary>
        /// Represent a non chageable variable for LastName
        /// </summary>
        private string _LastName;

        /// <summary>
        /// Represent a non changeable variable for PlayerName
        /// </summary>
        private string _InGameName;
        #endregion

        #region Properties for PersonModel
        /// <summary>
        /// Represent ID of this person
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represent the first name of this Person
        /// </summary>
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
        public string LastName { 
            get { return _LastName; }
            set 
            {
                try
                {

                }
                catch (DbUpdateException e )
                {
                    Console.WriteLine($"Your last name is longer than 50 characters. {e}");
                    throw;
                }
            } 
        }

        /// <summary>
        /// Represent the in game of this person
        /// </summary>
        public string PlayerName {
            get { return _InGameName; }
            set
            {
                try
                {

                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine($"Your Ingame name is longer than 100 characters.{e}");
                    throw;
                }
            } 
        }


        //MABY USED FOR FOREIGN KEY!!=!=! IDK 
        public ICollection<TeamModel> _TeamModels { get; set; }
        #endregion
    }
}

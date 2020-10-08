using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OrderFromCSharp
{
    /// <summary>
	/// The Volunteer class serves to store volunteer information : name, phone
	/// </summary>
    class Volunteer : People
    {

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Volunteer() : base()
        {

        }

        /// <summary>
        /// Volunteer constructor
        /// </summary>
        /// <param name="userName">Volunteer name</param>
        /// <param name="phoneNumber">Volunteer phone</param>
        public Volunteer(String userName, String phoneNumber) : base(userName, phoneNumber)
        {

        }


    }
}

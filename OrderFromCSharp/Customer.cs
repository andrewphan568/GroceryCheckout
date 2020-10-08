using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
    /// <summary>
     /// The Customer class serves to store people information : name, address, phone
     /// </summary>
    class Customer : People
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Customer() : base()
        {

        }

        /// <summary>
        /// Customer constructor
        /// </summary>
        /// <param name="userName">name</param>
        /// <param name="phoneNumber"> phone</param>
        /// /// <param name="address">addree</param>
        public Customer(String userName, String phoneNumber, String address) : base(userName, phoneNumber, address)
        {

        }
    }
}

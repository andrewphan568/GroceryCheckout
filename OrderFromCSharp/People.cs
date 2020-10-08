using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
	/// <summary>
	/// The People class serves to store people information : name, address, phone
	/// </summary>
	class People
    {
		private String name;		
		private String address;		
		private String phone;

		public People() { }

		/// <summary>
		/// People constructor
		/// </summary>
		/// <param name="userName">name</param>
		/// <param name="phoneNumber"> phone</param>
		public People(String userName, String phoneNumber) 
		{
			name = userName;
			phone = phoneNumber;
		}

		/// <summary>
		/// People constructor
		/// </summary>
		/// <param name="userName"> name</param>
		/// <param name="phoneNumber">phone</param>
		/// <param name="addreesA">address</param>
		public People(String userName, String phoneNumber, String addreesA)
		{
			name = userName;
			phone = phoneNumber;
			address = addreesA;
		}


		/// <summary>
		/// Read/write value to track phone
		/// </summary>
		public String Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		/// <summary>
		/// Read/write value to track address
		/// </summary>
		public String  Address
		{
			get { return address; }
			set { address = value; }
		}

		/// <summary>
		/// Read/write value to track name
		/// </summary>
		public String Name
		{
			get { return name; }
			set { name = value; }
		}

	}
}

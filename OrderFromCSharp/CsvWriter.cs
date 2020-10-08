using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
    /// <summary>
    /// The CsvReade class serves to read from csv files
    /// </summary>
    class CsvWriter
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public CsvWriter()
        {
        }

        /// <summary>
        /// Append order to OrderRecord file
        /// </summary>
        /// <param name="customer">Customer of the order</param>
        /// <param name="cost">total cost of order</param>
        /// <param name="volunteer">Volunteer assigned for the order</param>
        public void WriteOrderRecord(Customer customer, Double cost, Volunteer volunteer)
        {
            try
            {
                String line = customer.Name + "," + customer.Address + "," + customer.Phone + ",";
                line += DateTime.Now.ToString("dd/MM/yyyy") + "," + DateTime.Now.ToString("HH:mm:ss") + ",";
                line += cost + "," + volunteer.Name;
                File.AppendAllText("OrderRecords.csv", Environment.NewLine + line);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// Write a new shopping list to Shopping List file
        /// </summary>
        /// <param name="customer">Customer of the order</param>
        /// <param name="shoppingCart">list of selected products</param>
        /// <param name="volunteer">Volunteer assigned for the order</param>
        /// <param name="numberOfHouseHold">number of household</param>
        public void WriteShoppingList(ShoppingCart shoppingCart, Customer customer, Volunteer volunteer, int numberOfHouseHold)
        {

            FileStream fs = null;
            try
            {
                fs = new FileStream("ShoppingList.csv", FileMode.Truncate, FileAccess.Write);
                StreamWriter output = new StreamWriter(fs);
                output.WriteLine("Customer Name : " + "," + customer.Name);
                output.WriteLine("Customer Address : " + "," + customer.Address);
                output.WriteLine("Customer Phone : " + "," + customer.Phone);
                output.WriteLine("Number Of HouseHold : " + "," + numberOfHouseHold);
                output.WriteLine("Volunteer Name " + "," + volunteer.Name);
                output.WriteLine("DateTime: " + "," + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                output.WriteLine("No" + "," + "Product");

                for (int i = 0; i < shoppingCart.MyBasket.Count; i++)
                {
                    output.WriteLine(i + 1 + "," + shoppingCart.MyBasket.ElementAt(i).Key.Name);
                }
                output.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// Write a new volunteerList content
        /// </summary>   
        /// <param name="volunteer">List of volunteers need to write to file</param>
        public void CreateNewVolunteerList(List<Volunteer> volunteers)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("VolunteersList.csv", FileMode.Truncate, FileAccess.Write);
                StreamWriter output = new StreamWriter(fs);
                output.WriteLine("Volunteer Name , Volunteer Phone");
                foreach (Volunteer person in volunteers)
                {
                    output.WriteLine(person.Name + "," + person.Phone);
                }
                output.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

        }
    }
}

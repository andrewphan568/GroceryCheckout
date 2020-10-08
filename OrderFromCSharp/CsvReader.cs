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
    class CsvReader
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public CsvReader()
        {
        }

        /// <summary>
        /// Read VolunteersList file and add each volunteer to list
        /// </summary>
        /// <returns> List of volunteer </returns>
        public List<Volunteer> ReadVolunteerList()
        {
            List<Volunteer> volunteers = new List<Volunteer>();
            FileStream fs = null;
            try
            {
                String line = "";
                fs = new FileStream("VolunteersList.csv", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fs); //Create the file reader                                                   
                fileReader.ReadLine();                          //Read the CSV file header to skip it
                //Read the file line by line starting from the second line
                while ((line = fileReader.ReadLine()) != null)
                {
                    //Get all tokens available in line
                    String[] tokens = line.Split(',');
                    if (tokens.Length > 0)
                    {
                        Volunteer volunteer = new Volunteer((tokens[0]), tokens[1]);
                        volunteers.Add(volunteer);                  // add volunter to list                           
                    }
                }
                fileReader.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            return volunteers;
        }

        /// <summary>
        /// Read ProductList file and add each product to list
        /// </summary>
        /// <returns> List of product </returns>
        public List<Product> ReadProductList()
        {
            List<Product> products = new List<Product>();
            FileStream fs = null;
            try
            {
                String line = "";
                fs = new FileStream("ProductsList.csv", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fs); //Create the file reader                                                   
                fileReader.ReadLine();                          //Read the CSV file header to skip it
                //Read the file line by line starting from the second line
                while ((line = fileReader.ReadLine()) != null)
                {
                    //Get all tokens available in line
                    String[] tokens = line.Split(',');
                    if (tokens.Length > 0)
                    {
                        Product product = new Product((tokens[0]), tokens[1], Convert.ToDouble(tokens[2]), tokens[3]);
                        products.Add(product);                 // add product to list                             
                    }
                }
                fileReader.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            return products;
        }
    }
    
}

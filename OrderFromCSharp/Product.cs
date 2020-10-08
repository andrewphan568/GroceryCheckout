using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace OrderFromCSharp
{
    /// <summary>
	/// TheProduct class serves to store volunteer information : name, category,
    ///  price, price per (person, household,etc).
	/// </summary>
    class Product
    {
        private string name;
        private String category; 
        private Double price;
        private String pricePer;      

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Product constructor
        /// </summary>
        /// <param name=category">Product category</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        /// <param name="pricePer">Product price per (household, person,etc)</param>
        public Product(String category, String name, Double price, String pricePer)            
        {
            this.category = category;
            this.name = name;
            this.price = price;
            this.pricePer = pricePer;           
        }

        /// <summary>
        /// Read/write value to track price per (household, person,etc)
        /// </summary>
        public String PricePer
        {
            get { return pricePer; }
            set { pricePer = value; }
        }

        /// <summary>
        /// Read/write value to track price
        /// </summary>
        public Double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Read/write value to track category
        /// </summary>
        public String Category
        {
            get { return category; }
            set { category = value; }
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

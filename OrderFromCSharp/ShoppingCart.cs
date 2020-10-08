using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
    class ShoppingCart
    {

        private Dictionary<Product, int> basket;  // store list of selected products with quantity   

        /// <summary>
        /// Empty constructor
        /// </summary>
        public ShoppingCart() {
            basket = new Dictionary<Product, int>(); ;
        }

        /// <summary>
        /// Add product to basket
        /// </summary>
        /// <param name="item">Product needed to add</param>
        /// <param name="quantity">reference quantity of product: it may be the number of household or the number from text box</param>     
        public void AddToCart(Product item, int quantityRef) {
            if (item != null && quantityRef >= 0) {
                if (basket.ContainsKey(item)) {
                    RemoveFromCart(item);
                }
                basket.Add(item, quantityRef);
            }       
        }

        /// <summary>
        /// Remove product from basket
        /// </summary>
        /// <param name="item">Product needed to remove</param>         
       public void RemoveFromCart(Product item)
        {
            if (item != null){
                basket.Remove(item);
            }
        }

        /// <summary>
        /// Update reference quantity for product when number of household changed
        /// </summary>
        /// <param name="newQuantityRef">new reference quantity of product</param>  
        public void UpdateQuantityRef(int newQuantityRef)
        {
            if (newQuantityRef >= 0)
            {
                foreach (Product item in basket.Keys.ToList())
                {
                    if (!item.PricePer.Equals("quantity")) {
                        basket[item] = newQuantityRef;
                    }                    
                }               
            }
        }

        /// <summary>
        /// Read/write value to track basket
        /// </summary>
        public Dictionary<Product, int> MyBasket
        {
            get { return basket; }
            set { basket = value; }
        }
    }
}

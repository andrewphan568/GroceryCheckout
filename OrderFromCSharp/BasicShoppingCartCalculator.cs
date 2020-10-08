using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
    class BasicShoppingCartCalculator : ICostCalculator
    {
        public static double deliveryFee = 5;

        public BasicShoppingCartCalculator() { 
        }

        public double CalculateBasicCost(ShoppingCart shoppingCart)
        {
            double totalCost = 0;          

            if (shoppingCart.MyBasket.Count > 0)
            {
                          
                foreach (Product item in shoppingCart.MyBasket.Keys.ToList())
                {                  
                    if (item.PricePer.Equals("quantity"))
                    {
                        totalCost += item.Price * shoppingCart.MyBasket[item];                       
                    }
                    else if (item.PricePer.Equals("household"))
                    {
                        totalCost += item.Price * 1;                   
                    }
                    else if (item.PricePer.Equals("person"))
                    {
                        totalCost += item.Price * shoppingCart.MyBasket[item];              
                    }
                    else if (item.PricePer.Equals("two person"))
                    {
                        totalCost += item.Price * Math.Ceiling(shoppingCart.MyBasket[item] / (double)2);                       
                    }
                }
            }            
            return totalCost;
        }

        public double TotalCostWithDelivery(ShoppingCart shoppingCart)
        {
            return CalculateBasicCost(shoppingCart) + deliveryFee;
        }
    }
}

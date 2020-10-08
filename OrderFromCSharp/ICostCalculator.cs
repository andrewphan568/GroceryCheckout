using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFromCSharp
{
    interface ICostCalculator
    {
        double CalculateBasicCost(ShoppingCart shoppingCart);
        double TotalCostWithDelivery(ShoppingCart shoppingCart);
    }
}

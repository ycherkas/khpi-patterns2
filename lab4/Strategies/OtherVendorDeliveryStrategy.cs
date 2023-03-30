using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Strategies
{
    internal class OtherVendorDeliveryStrategy : IFoodDeliveryStrategy
    {
        public double CalculateCost(object location, object[] orders)
        {
            return new Random().NextDouble();
        }
    }
}

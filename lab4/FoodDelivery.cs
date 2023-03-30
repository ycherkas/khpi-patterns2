using Lab4.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FoodDelivery
    {
        private IFoodDeliveryStrategy _strategy;

        public FoodDelivery(IFoodDeliveryStrategy strategy)
        {
            _strategy = strategy;
        }


        public void SetStrategy(IFoodDeliveryStrategy strategy)
        {
            _strategy = strategy;
        }

        public double CalculateCost(object location, object[] orders)
        {
            return _strategy.CalculateCost(location, orders);
        }
    }
}

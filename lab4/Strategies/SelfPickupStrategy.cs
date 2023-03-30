namespace Lab4.Strategies
{
    public class SelfPickupStrategy : IFoodDeliveryStrategy
    {
        public double CalculateCost(object location, object[] orders)
        {
            return new Random().NextDouble();
        }
    }
}

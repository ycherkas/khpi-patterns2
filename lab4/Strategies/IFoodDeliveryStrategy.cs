namespace Lab4.Strategies
{
    public interface IFoodDeliveryStrategy
    {
        double CalculateCost(object location, object[] orders);
    }
}

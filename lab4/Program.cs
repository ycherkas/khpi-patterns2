// See https://aka.ms/new-console-template for more information
using Lab4;
using Lab4.Strategies;

Console.WriteLine("Hello, World!");

var location = new
{
    Longitude = 49.8397,
    Latitude = 24.0297
};
var orders = new[]
{
   new { Name = "Hamburger", Amount = 1 },
   new { Name = "Cola 0.5l", Amount = 2 }
};

var selfPickupStrategy = new SelfPickupStrategy();
var ownDeliveryStrategy = new OwnDeliveryStrategy();
var otherVendorDeliveryStrategy = new OtherVendorDeliveryStrategy();

var foodDelivery = new FoodDelivery(selfPickupStrategy);

Console.WriteLine($"Self Pickup price: {foodDelivery.CalculateCost(location, orders)}");

foodDelivery.SetStrategy(ownDeliveryStrategy);

Console.WriteLine($"Own Delivery vendor price: {foodDelivery.CalculateCost(location, orders)}");

foodDelivery.SetStrategy(otherVendorDeliveryStrategy);

Console.WriteLine($"3rd party vendor price: {foodDelivery.CalculateCost(location, orders)}");
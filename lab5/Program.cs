using Lab5;
using Lab5.Handlers;
using Lab5.Models;

var productRequest = new ProductModel
{
    Id = 1,
    Name = "Banana",
    Price = 1.4M
};
var userRequest = new UserModel
{
    Id = 21,
    Username = "JohnDoe",
    Email = "john.doe@gmail.com"
};
var orderRequest = new OrderModel
{
    Id = 39,
    ProductId = 1,
    Quantity = 15
};

var productHandler = new ProductHandler();
var userHandler = new UserHandler();
var orderHandler = new OrderHandler();

ClientAPI.Process(productHandler, productRequest);
ClientAPI.Process(userHandler, userRequest);
ClientAPI.Process(orderHandler, orderRequest);

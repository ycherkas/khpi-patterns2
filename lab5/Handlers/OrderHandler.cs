using Lab5.Models;
using Lab5.Responses;
using System.Text.Json;

namespace Lab5.Handlers
{
    public class OrderHandler : AbstractHandler
    {
        protected override OrderModel GetExistingObjectFromDb(int id)
        {
            return new OrderModel() { Id = id };
        }

        protected override bool IsValid(BaseModel existingObject, BaseModel request)
        {
            //TODO: implement
            return true;
        }

        protected override bool UpdateObjectInDb(BaseModel request)
        {
            //TODO: implement
            return true;
        }

        protected override OrderResponse CreateResponse(bool updateSucceeded, BaseModel request)
        {
            var baseResponse = base.CreateResponse(updateSucceeded, request);

            return new OrderResponse
            {
                Status = baseResponse.Status,
                Message = baseResponse.Message,
                OrderJson = JsonSerializer.Serialize(request)
            };
        }
    }
}

using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public class ProductHandler : AbstractHandler
    {
        protected override ProductModel GetExistingObjectFromDb(int id)
        {
            return new ProductModel() { Id = id };
        }

        protected override bool IsValid(BaseModel existingObject, BaseModel request)
        {
            //TODO: implement
            return true;
        }

        protected new void ValidationFailedHook(object request) 
        { 
            //TODO: send message to Administrator
        }

        protected override bool UpdateObjectInDb(BaseModel request)
        {
            //TODO: implement
            return true;
        }
    }
}

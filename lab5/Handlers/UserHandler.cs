using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public class UserHandler : AbstractHandler
    {
        protected override BaseModel GetExistingObjectFromDb(int id)
        {
            return new UserModel() { Id = id };
        }

        protected override bool IsValid(BaseModel existingObject, BaseModel request)
        {
            var existingModel = (UserModel)existingObject;
            var requestModel = (UserModel)request;

            //New User
            if (existingModel == null)
            {
                return true;
            }

            if (existingModel.Email != requestModel.Email)
            {
                return false;
            }

            return true;
        }

        protected override bool UpdateObjectInDb(BaseModel request)
        {
            //TODO: implement
            return true;
        }
    }
}

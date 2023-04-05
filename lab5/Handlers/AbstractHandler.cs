using Lab5.Models;
using Lab5.Responses;

namespace Lab5.Handlers
{
    public abstract class AbstractHandler
    {
        public BaseResponse Handle(BaseModel request)
        {
            var existingObject = GetExistingObjectFromDb(request.Id);

            if (!IsValid(existingObject, request))
            {
                ValidationFailedHook(request);

                return new BaseResponse
                {
                    Status = 400,
                    Message = "Validation failed"
                };
            }

            var updateSucceeded = UpdateObjectInDb(request);

            return CreateResponse(updateSucceeded, request);
        }

        protected abstract BaseModel GetExistingObjectFromDb(int id);

        protected abstract bool IsValid(BaseModel existingObject, BaseModel request);

        protected void ValidationFailedHook(object request) { }

        protected abstract bool UpdateObjectInDb(BaseModel request);

        protected virtual BaseResponse CreateResponse(bool updateSucceeded, BaseModel request)
        {
            if (updateSucceeded)
            {
                return new BaseResponse
                {
                    Status = 200,
                    Message = "Object was successfully updated in DB"
                };
            }

            return new BaseResponse
            {
                Status = 500,
                Message = $"Object update failed: Id={request.Id}. Please contact support"
            };
        }

    }
}

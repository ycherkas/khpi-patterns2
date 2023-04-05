using Lab5.Handlers;
using Lab5.Models;
using Lab5.Responses;

namespace Lab5
{
    public class ClientAPI
    {
        public static BaseResponse Process(AbstractHandler handler, BaseModel request)
        {
            return handler.Handle(request);
        }
    }
}

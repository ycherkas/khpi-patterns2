using Lab9.Concrete;

namespace Lab9.Interfaces
{
    public interface IYouTubeApi
    {
        void Upload(Video video, string clientId, string clientSecret);
    }
}

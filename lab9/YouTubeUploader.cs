using Lab9.Concrete;
using Lab9.Interfaces;

namespace Lab9
{
    public class YouTubeUploader
    {
        private IYouTubeApi _youTubeApi;
        private IFileManager _fileManager;
        private IVideoConverter _videoConverter;
        private string _clientId;
        private string _clientSecret;

        public YouTubeUploader(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;

            _youTubeApi = new YouTubeApi();
            _fileManager = new FileManager();
            _videoConverter = new VideoConverter();
        }

        public void Upload(string filePath)
        {
            var byteArray = _fileManager.ReadFromDisk(filePath);

            var video = _videoConverter.Convert(byteArray, filePath, "mp4");

            _youTubeApi.Upload(video, _clientId, _clientSecret);
        }
    }
}

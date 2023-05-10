using Lab9.Interfaces;

namespace Lab9.Concrete
{
    public class VideoConverter: IVideoConverter
    {
        public Video Convert(byte[] data, string fileName, string format)
        {
            if(format != "mp4")
                throw new NotImplementedException();

            return new Video
            {
                Name = fileName,
                Data = data,
                Format = "mp4"
            };
        }
    }
}

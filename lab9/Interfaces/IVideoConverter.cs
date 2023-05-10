using Lab9.Concrete;

namespace Lab9.Interfaces
{
    public interface IVideoConverter
    {
        Video Convert(byte[] data, string fileName, string format);
    }
}

using Lab9.Interfaces;

namespace Lab9.Concrete
{
    public class FileManager: IFileManager
    {
        public byte[] ReadFromDisk(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }
    }
}

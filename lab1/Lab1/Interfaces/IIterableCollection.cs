namespace Lab1.Interfaces
{
    public interface IIterableCollection<T>
    {
        public IIterator<T> CreateTouristIterator();
        public IIterator<T> CreateNavigatorIterator();
        public IIterator<T> CreateGuideIterator();
        int Count { get; }
        T this[int index] { get; set; }
    }
}

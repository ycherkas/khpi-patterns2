using Lab1.Interfaces;

namespace Lab1.Concrete
{
    public class GuideIterator : IIterator<TouristPlace>
    {
        private readonly IIterableCollection<TouristPlace> _collection;
        private int _index;

        public GuideIterator(IIterableCollection<TouristPlace> collection)
        {
            _collection = collection;
        }


        public bool HasNext()
        {
            return _index < _collection.Count;
        }

        public TouristPlace Next()
        {
            //TODO: change to real implementation
            return _collection[_index++];
        }
    }
}

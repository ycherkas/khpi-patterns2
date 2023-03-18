using Lab1.Interfaces;

namespace Lab1.Concrete
{
    public class TouristPlaceCollection : IIterableCollection<TouristPlace>
    {
        private readonly List<TouristPlace> _places;

        public TouristPlaceCollection()
        {
            _places = new List<TouristPlace>();
        }

        public TouristPlaceCollection(List<TouristPlace> places)
        {
            _places = places;
        }

        public IIterator<TouristPlace> CreateTouristIterator()
        {
            return new TouristIterator(this);
        }

        public IIterator<TouristPlace> CreateNavigatorIterator()
        {
            return new NavigatorIterator(this);
        }

        public IIterator<TouristPlace> CreateGuideIterator()
        {
            return new GuideIterator(this);
        }

        public int Count
        {
            get { return _places.Count; }
        }

        public TouristPlace this[int index]
        {
            get { return _places[index]; }
            set { _places.Insert(index, value); }
        }
    }
}

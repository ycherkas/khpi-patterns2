using Lab1.Interfaces;

namespace Lab1
{
    public class TouristVisitor
    {
        public void Visit(IIterator<TouristPlace> iterator, string title)
        {
            Console.WriteLine($"{title}:");

            while (iterator.HasNext())
            {
                var place = iterator.Next();
                Console.WriteLine(place.Name);
            }

            Console.WriteLine();
        }
    }
}

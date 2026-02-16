using IteratorImplementation.Classes.Contracts;

namespace IteratorImplementation.Classes.Implementations
{
    public class PeopleCollection : List<Person>, IPeopleCollection
    {
        public IPeopleIterator CreateIterator()
        {
            return new PeopleIterator(this);
        }
    }
}

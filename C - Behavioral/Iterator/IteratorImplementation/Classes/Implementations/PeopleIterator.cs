using IteratorImplementation.Classes.Contracts;

namespace IteratorImplementation.Classes.Implementations
{
    public class PeopleIterator : IPeopleIterator
    {
        private PeopleCollection _peopleCollection;
        private int _current = 0;

        public PeopleIterator(PeopleCollection peopleCollection)
        {
            _peopleCollection = peopleCollection;
        }

        public bool IsDone { get => _current >= _peopleCollection.Count(); }

        public Person CurrentItem { get => _peopleCollection.OrderBy(p => p.Name).ToList()[_current]; }

        public Person First()
        {
            _current = 0;
            return _peopleCollection
                .OrderBy(p => p.Name).ToList()[_current];
        }

        public Person Next()
        {
            _current++;

            if (!IsDone)
                return _peopleCollection.OrderBy(p => p.Name).ToList()[_current];

            return null;
        }
    }
}

using IteratorImplementation.Classes.Implementations;

namespace IteratorImplementation.Classes.Contracts
{
    public interface IPeopleIterator
    {
        Person First();
        Person Next();
        bool IsDone { get; }
        Person CurrentItem { get; }
    }
}

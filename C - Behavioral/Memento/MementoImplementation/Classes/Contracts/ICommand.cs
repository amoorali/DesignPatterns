namespace MementoImplementation.Classes.Contracts
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}

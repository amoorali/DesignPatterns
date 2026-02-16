namespace VisitorImplementation.Classes.Contracts
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

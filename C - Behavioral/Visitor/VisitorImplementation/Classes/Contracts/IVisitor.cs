namespace VisitorImplementation.Classes.Contracts
{
    //public interface IVisitor
    //{
    //    void VisitCustomer(Customer customer);
    //    void VIsitEmployee(Employee employee);
    //}

    public interface IVisitor
    {
        void Visit(IElement element);
    }
}

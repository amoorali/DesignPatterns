using VisitorImplementation.Classes.Contracts;

namespace VisitorImplementation.Classes.Implementations
{
    public class Container
    {
        public List<Customer> Customers { get; set; } = new();
        public List<Employee> Employees { get; set; } = new();

        public void Accept(IVisitor visitor)
        {
            foreach(var customer in Customers)
                customer.Accept(visitor);

            foreach(var employee in Employees)
                employee.Accept(visitor);
        }
    }
}

using VisitorImplementation.Classes.Contracts;

namespace VisitorImplementation.Classes.Implementations
{
    public class Employee :IElement
    {
        public string Name { get; private set; }
        public int YearsEmployed { get; private set; }
        public decimal Discount { get; set; }

        public Employee(string name, int yearsEmployed)
        {
            Name = name;
            YearsEmployed = yearsEmployed;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            Console.WriteLine($"Visited {nameof(Employee)} {Name}, discount given {Discount}");
        }
    }
}

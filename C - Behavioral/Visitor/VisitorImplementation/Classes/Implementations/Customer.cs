using VisitorImplementation.Classes.Contracts;

namespace VisitorImplementation.Classes.Implementations
{
    public class Customer : IElement
    {
        public string Name { get; private set; }
        public decimal AmountOrdered { get; private set; }
        public decimal Discount { get; set; }

        public Customer(string name, decimal amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            Console.WriteLine($"Visited {nameof(Customer)} {Name}, discount given {Discount}");
        }
    }
}

using VisitorImplementation.Classes.Contracts;

namespace VisitorImplementation.Classes.Implementations
{
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountGiven { get; set; }

        public void Visit(IElement element)
        {
            if (element is Employee)
                VIsitEmployee((Employee)element);
            else if (element is Customer)
                VisitCustomer((Customer)element);
        }

        private void VisitCustomer(Customer customer)
        {
            var discount = customer.AmountOrdered / 10;

            customer.Discount = discount;
            TotalDiscountGiven += discount;
        }

        private void VIsitEmployee(Employee employee)
        {
            var discount = employee.YearsEmployed < 10 ? 100 : 200;

            employee.Discount = discount;
            TotalDiscountGiven += discount;

            employee.Discount = discount;
        }
    }
}

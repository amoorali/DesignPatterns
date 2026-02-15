using StrategyImplementation.Contracts;

namespace StrategyImplementation.Implementations
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Order(int customerId, string name, string? description)
        {
            CustomerId = customerId;
            Name = name;
            Description = description;
        }

        public void Export(IExportService exportService)
        {
            exportService.Export(this);
        }
    }
}

using StrategyImplementation.Contracts;

namespace StrategyImplementation.Implementations
{
    public class XmlExportSerevice : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting the order {order.Id} to XML.");
        }
    }
}

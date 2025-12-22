namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Factory Method";

            var factories = new List<DiscountFactory>
            {
                new CountryDiscountFactory("IR"),
                new CodeDiscountFactory(Guid.NewGuid())
            };

            foreach (var factory in factories)
            {
                var discountService = factory.CreateDiscountService();

                Console.WriteLine($"Percentage {discountService.DiscountPercentage} " +
                    $"coming from {discountService}");
            }
        }
    }
}

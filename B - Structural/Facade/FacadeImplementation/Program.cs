using FacadeImplementation.Classes.Implementations;

namespace FacadeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var discountCalculator = new DiscountCalculator();

            Console.WriteLine(discountCalculator.Calculate(10));
            Console.WriteLine(discountCalculator.Calculate(1));

        }
    }
}

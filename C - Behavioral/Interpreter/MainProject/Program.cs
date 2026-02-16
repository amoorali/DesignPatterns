using InterpreterImplementation.Classes.Contracts;
using InterpreterImplementation.Classes.Implementations;

namespace InterpreterImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var expressions = new List<IRomanExpression>()
            {
                new RomanHundredExpression(),
                new RomanTenExpression(),
                new RomanOneExpression()
            };

            var context = new RomanContext(534);
            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"Translating Arabic numerals to Roman numerals: 534 = {context.Output}");
        }
    }
}

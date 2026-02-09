namespace FunctionDecorators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = PrintResult(Add);
            Func<int, int, int> addPrintSquare = Square(add);
            Func<int, int, int> addSquarePrint = PrintResult(Square(Add));

            Console.WriteLine(add(5, 5));
            Console.WriteLine(addPrintSquare(5, 5));
            Console.WriteLine("after");
            Console.WriteLine(addSquarePrint(5, 5));
        }

        static int Add(int a, int b) => a + b;

        static Func<int, int, int> PrintResult(Func<int, int, int> function)
        {
            return (int a, int b) =>
            {
                int result = function(a, b);

                Console.WriteLine("inside");

                return result;
            };
        }

        static Func<int, int, int> Square(Func<int, int, int> function)
        {
            return (int a, int b) =>
            {
                int result = function(a, b);

                return result * result;
            };
        }
    }
}

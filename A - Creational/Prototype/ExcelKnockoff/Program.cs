using ExcelKnockoff.Contracts;
using ExcelKnockoff.Implementations;

namespace ExcelKnockoff
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBlock> grid = new List<IBlock>()
            {
                BlockFactory.Create("HelloWorld!"),
                BlockFactory.Create("10/11/1908"),
                BlockFactory.Create("12381938"),
                BlockFactory.Create("S 10/11/2002"),

            };

            foreach(var block in grid)
            {
                var content = string.Empty;
                int? number = null;
                DateTime? dateTime = null;
                var format = string.Empty;

                if (block is TextBlock)
                    content = (block as TextBlock)!.Content;

                if (block is NumberBlock)
                    number = (block as NumberBlock)!.Number;

                if (block is DateTimeBlock)
                {
                    dateTime = (block as DateTimeBlock)!.DateTime;
                    format = (block as DateTimeBlock)!.Format;
                }

                Console.WriteLine($"Render: {block.Render}\tContent: {content}\t" +
                    $"Number: {number}\tDateTime: {dateTime}\tFormat: {format}");
            }
        }
    }
}

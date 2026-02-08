using ExcelKnockoff.Contracts;
using ExcelKnockoff.Implementations;

namespace ExcelKnockoff
{
    public class BlockFactory
    {
        public static IBlock Create(string content)
        {
            if (DateTime.TryParse(content, out var dateTime))
            {
                return new DateTimeBlock()
                {
                    Format = "dd/MM/yyyy",
                    DateTime = dateTime
                };
            }

            if (int.TryParse(content, out var intValue))
                return new NumberBlock() { Number = intValue };

            return new TextBlock() { Content = content };
        }
    }
}

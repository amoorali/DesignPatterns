using ExcelKnockoff.Contracts;

namespace ExcelKnockoff.Implementations
{
    public class DateTimeBlock : IBlock
    {
        public DateTime DateTime { get; set; }
        public string Format { get; set; } = "dd/MM/yyyy";

        public IBlock Clone() => new DateTimeBlock()
        {
            Format = Format,
            DateTime = DateTime
        };

        public string Render => DateTime.ToString(Format);
    }
}

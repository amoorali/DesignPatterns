using ExcelKnockoff.Contracts;

namespace ExcelKnockoff.Implementations
{
    public class TextBlock : IBlock
    {
        public string Content { get; set; } = string.Empty;

        public IBlock Clone() => new TextBlock() { Content = Content };
            
        public string Render => Content;
    }
}

namespace ExcelKnockoff.Contracts
{
    public interface IBlock
    {
        public string Render { get; }
        public IBlock Clone();
    }
}

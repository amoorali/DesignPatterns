namespace SharedObjectFlyweight.Classes.Contracts
{
    public interface ITree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ITreeType Type { get; set; }
    }
}

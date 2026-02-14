namespace SharedObjectFlyweight.Classes.Contracts
{
    public interface ITreeFactory
    {
        public ITree? GetTree(int x, int y);
        public IPark CreatePark(string name, string? description, List<ITree>? trees);
    }
}

using SharedObjectFlyweight.Classes.Contracts;

namespace SharedObjectFlyweight.Classes.Implementations
{
    public class TreeFactory : ITreeFactory
    {
        private List<ITree> _trees;

        public IPark CreatePark(string name, string? description, List<ITree> trees)
        {
            _trees = trees;

            var park = new Park(name, description, _trees);

            return park;
        }

        public ITree? GetTree(int x, int y)
        {
            return _trees.Where(t => t.X == x && t.Y == y).FirstOrDefault();
        }
    }
}

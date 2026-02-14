using SharedObjectFlyweight.Classes.Contracts;

namespace SharedObjectFlyweight.Classes.Implementations
{
    public class Tree : ITree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ITreeType Type { get; set; }

        public Tree(int x, int y, ITreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }
    }
}

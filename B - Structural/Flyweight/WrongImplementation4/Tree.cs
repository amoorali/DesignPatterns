namespace WrongImplementation4
{
    public class Tree
    {
        public string Texture { get; set; }
        public string Model { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Tree(string texture, string model, int x, int y)
        {
            Texture = texture;
            Model = model;
            X = x;
            Y = y;
        }
    }
}

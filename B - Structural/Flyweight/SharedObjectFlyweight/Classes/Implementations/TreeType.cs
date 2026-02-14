using SharedObjectFlyweight.Classes.Contracts;

namespace SharedObjectFlyweight.Classes.Implementations
{
    public class TreeType : ITreeType
    {
        public string Texture { get; set; }
        public string Model { get; set; }

        public TreeType(string texture, string model)
        {
            Texture = texture;
            Model = model;
        }
    }
}

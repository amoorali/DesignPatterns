using SharedObjectFlyweight.Classes.Contracts;

namespace SharedObjectFlyweight.Classes.Implementations
{
    public class Park : IPark
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<ITree>? Trees { get; set; }

        public Park(string name, string? description, List<ITree>? trees)
        {
            Name = name;
            Description = description;
            Trees = trees;
        }

        public void ShowPark()
        {
            Console.WriteLine("Park with many trees.");
        }
    }
}

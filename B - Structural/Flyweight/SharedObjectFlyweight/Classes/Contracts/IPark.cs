namespace SharedObjectFlyweight.Classes.Contracts
{
    public interface IPark
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<ITree>? Trees { get; set; }

        public void ShowPark();
    }
}

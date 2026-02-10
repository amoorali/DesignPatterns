namespace CompositeTree.Classes.Contracts
{
    public interface INode
    {
        public string Data { get; set; }
        public List<INode> Nodes { get; set; }

        public void ComputeNodes();

        public void Add(INode node);
    }
}

using CompositeTree.Classes.Contracts;

namespace CompositeTree.Classes.Implementations
{
    public class Node : INode
    {
        public string Data {  get; set; }

        public List<INode> Nodes { get; set; } = new List<INode>();

        public Node(string data)
        {
            Data = data;
        }

        public void ComputeNodes()
        {
            foreach (var node in Nodes)
            {
                Console.WriteLine(node.Data);
                node.ComputeNodes();
            }
        }

        public void Add(INode node)
        {
            Nodes.Add(node);
        }
    }
}

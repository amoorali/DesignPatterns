using CompositeTree.Classes.Implementations;

namespace CompositeTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var top = new Node("Top");

            Console.WriteLine("Node:   - Parent:  ");

            var node1 = new Node("Node: 1 - Parent: 0");
            var node2 = new Node("Node: 2 - Parent: 0");
            var node3 = new Node("Node: 3 - Parent: 1");

            top.Add(node1);
            top.Add(node2);

            node1.Add(node3);

            top.ComputeNodes();
        }
    }
}

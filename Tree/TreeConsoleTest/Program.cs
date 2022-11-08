using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        FloatBinarTree tree = new FloatBinarTree(5);
        tree.Add(4);
        tree.Add(2);
        tree.Add(1);
        tree.Add(6);
        tree.Add(7);
        tree.Add(2);
        Console.WriteLine(tree);
    }
}
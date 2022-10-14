using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        FloatBinarTree tree = new(5);
        tree.Root.AddBranch(3);
        tree.Root.AddBranch(1);
        tree[0].AddBranch(4);
        tree[0].AddBranch(5);
        tree[1].AddBranch(1);
        tree[1].AddBranch(13);
        tree[1][0].AddBranch(1);
        tree[1][0].AddBranch(3);
        tree[1][1].AddBranch(10);
        tree[1][1].AddBranch(15);
        Console.WriteLine(tree);
        Console.WriteLine("==============================");
        tree[1].RemoveItem(1);
        Console.WriteLine(tree);
    }
}
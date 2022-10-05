using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree<int> tree = new(5);
        tree.Root.AddLeave(3);
        tree.Root.AddLeave(1);
        tree.Root.AddLeave(2);

        Console.WriteLine($"{tree[0].Value} {tree[1].Value} {tree[2].Value}");

        tree[0].AddLeave(4);
        tree[0].AddLeave(5);
        tree[1].AddLeave(1);

        Console.WriteLine($"{tree[0][0].Value} {tree[0][1].Value} {tree[1][0].Value}");
    }
}
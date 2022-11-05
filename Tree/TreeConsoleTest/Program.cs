using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        Test3();


        void Test1()
        {
            FloatBinarTree newTree = new(1);
            newTree.AddRange(new float[] { -5, 5, 3, 8, 6, 10 });
            Console.WriteLine(newTree);
            newTree.Root.RemoveItem(1);
            Console.WriteLine(newTree);
        }

        void Test2()
        {
            FloatBinarTree newTree = new(6);
            newTree.AddRange(new float[] { 5, 7, 9 });
            Console.WriteLine(newTree);
            newTree.Root.RemoveItem(1);
            Console.WriteLine(newTree);
        }

        void Test3()
        {
            FloatBinarTree newTree = new(100);
            newTree.AddRange(new float[] { 5, 110, 105, 180, 102, 106, 115, 190, 116 });
            Console.WriteLine(newTree);
            newTree.Root.RemoveItem(1);
            Console.WriteLine(newTree);
        }

        void Test4()
        {
            FloatBinarTree newTree = new(100);
            newTree.AddRange(new float[] { 5, 110, 105, 180, 102, 106, 115, 190, 116 });

            foreach (FloatBinarTreeBranch branch in newTree.ToList())
            {
                Console.WriteLine($"{branch.Value} ");
            }
        }
    }  
}
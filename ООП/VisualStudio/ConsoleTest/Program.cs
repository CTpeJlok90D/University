internal class Program
{
    private static void Main(string[] args)
    {
        A a = new B();

        Console.WriteLine(a.GetType());
    }
}

class A
{

}

class B:A { }
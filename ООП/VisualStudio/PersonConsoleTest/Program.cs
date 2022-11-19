using Persons;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new("Петя", 55);
        Console.WriteLine(person);
        Console.WriteLine("=====================================");
        Student student = new("Вася", 20, 3, 55);
        Console.WriteLine(student);
    }
}
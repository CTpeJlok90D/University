namespace Persons
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        ~Person() { }

        public override string ToString()
        {
            return $"Имя: {Name}\n" +
                   $"Возраст: {Age}";
        }
    }
}
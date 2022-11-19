namespace Persons
{
    public class Teacher : Person
    {
        private string _department;
        public Teacher(string name, int age, string department) : base(name, age)
        {
            _department = department;
        }

        public string Department => _department;

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Кафедра: {_department}";
        }
    }
}

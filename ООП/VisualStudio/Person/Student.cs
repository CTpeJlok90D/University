namespace Persons
{
    public class Student : Person
    {
        private string _studyDirection;

        public Student(string name, int age, string studyDirection) : base(name, age)
        {
            _studyDirection = studyDirection;
        }

        public string StudyDirection => _studyDirection;

        public override string ToString()
        {
            return base.ToString() + "\n" + 
                $"Направление подготовки: {_studyDirection}";
        }
    }
}

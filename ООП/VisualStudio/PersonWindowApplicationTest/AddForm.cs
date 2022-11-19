using Persons;

namespace PersonWindowApplicationTest
{
    public partial class AddForm : Form
    {
        private const int StudentTabIndex = 0;
        private const int TeacherTabIndex = 1;
        private Dictionary<Type, List<Person>> _personContainer;

        public AddForm(Dictionary<Type, List<Person>> container)
        {
            _personContainer = container;
            InitializeComponent();
        }

        private void ApplyButtonOnClick(object sender, EventArgs e)
        {
            if (TryReadData(out Person person))
            {
                if (_personContainer.ContainsKey(person.GetType()) == false)
                {
                    _personContainer.Add(person.GetType(), new List<Person>());
                }
                _personContainer[person.GetType()].Add(person);
                Close();
                return;
            }
            MessageBox.Show("Ошибка чтения данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TryReadData(out Person person)
        {
            string name = "name";
            int age = 0;
            try
            {
                name = _nameTextBox.Text;
                age = int.Parse(_ageTextBox.Text);
                if (_seletectWorkTabControl.SelectedIndex == StudentTabIndex)
                {
                    string studyDictionarity = _studyDictionarity.Text;
                    person = new Student(name, age, studyDictionarity);
                    return true;
                }
                if (_seletectWorkTabControl.SelectedIndex == TeacherTabIndex)
                {
                    string department = _departmentTextBox.Text;
                    person = new Teacher(name, age, department);
                    return true;
                }
                person = new Person(name, age);
                return false;
            }
            catch
            {
                person = new Person(name, age);
                return false;
            }
            
        }
    }
}

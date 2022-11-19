using Persons;

namespace PersonWindowApplicationTest
{
    public partial class ShowForm : Form
    {
        private Dictionary<Type, List<Person>> _personContainer = new()
        {
            [typeof(Student)] = new List<Person>(),
            [typeof(Teacher)] = new List<Person>(),
        };
        public ShowForm()
        {
            InitializeComponent();
            _studentListBox.DisplayMember = "Name";
            _teacherListBox.DisplayMember = "Name";
        }

        public void AddButtonOnClick(object sender, EventArgs arg)
        {
            new AddForm(_personContainer).ShowDialog();
            UpdateList();
        }

        private void UpdateList()
        {
            _studentListBox.Items.Clear();
            _studentListBox.Items.AddRange(_personContainer[typeof(Student)].ToArray());
            _teacherListBox.Items.Clear();
            _teacherListBox.Items.AddRange(_personContainer[typeof(Teacher)].ToArray());
        }

        private void OnSelectedTeacherIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = _teacherListBox.SelectedIndex;
            _infoTextBox.Text = ((Teacher)_personContainer[typeof(Teacher)][selectedIndex]).ToString();
        }

        private void OnSelectedStudentIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = _studentListBox.SelectedIndex;
            _infoTextBox.Text = ((Student)_personContainer[typeof(Student)][selectedIndex]).ToString();
        }
    }
}
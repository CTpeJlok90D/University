namespace MovebleObjects
{
    public partial class N3 : Form
    {
        private Space _space;
        private List<Object> _objects = new();

        private Object selectedObject => _objects[_objectListBox.SelectedIndex];

        public N3()
        {
            InitializeComponent();
            _objects.Add(new Cirle(new Vector2(100, 100), new Vector2(100, 100)));
            _objects.Add(new Square(new Vector2(300, 300), new Vector2(100, 100)));
            _space = new(_objects);
            _objectListBox.DataSource = _objects;
            _objectListBox.DisplayMember = "Name";
            UpdateImage();
        }

        private void MoveButtonUpClick(object sender, EventArgs e)
        {
            selectedObject.Move(Vector2.down * 10);
            UpdateImage();
        }

        private void MoveButtonLeftClick(object sender, EventArgs e)
        {
            selectedObject.Move(Vector2.left * 10);
            UpdateImage();
        }

        private void MoveButtonDownClick(object sender, EventArgs e)
        {
            selectedObject.Move(Vector2.up * 10);
            UpdateImage();
        }

        private void MoveButtonRightClick(object sender, EventArgs e)
        {
            selectedObject.Move(Vector2.right * 10);
            UpdateImage();
        }

        private void UpdateImage()
        {
            _pictureBox.Image = _space.Render(_pictureBox.Size);
        }
    }
}
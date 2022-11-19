namespace MovebleObjects
{
    public partial class N3 : Form
    {
        private Space _space;
        private List<Object> _objects = new();
        private int _moveSpeed = 10;
        private Object? _clickedObject;

        private Object selectedObject => _objects[_objectListBox.SelectedIndex];

        public N3()
        {
            InitializeComponent();
            _objects.Add(new Cirle(new Point(100, 100), new Point(100, 100)));
            _objects.Add(new Square(new Point(300, 300), new Point(100, 100)));

            _space = new(_objects, new Point(_pictureBox.Size.Width, _pictureBox.Size.Height));

            _objectListBox.DataSource = _objects;
            _objectListBox.DisplayMember = "Name";
            RenderImage();
        }

        private void RenderImage()
        {
            _pictureBox.Image = _space.Render();
        }

        private void MoveButtonUpClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Point.down * _moveSpeed);
            RenderImage();
        }

        private void MoveButtonLeftClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Point.left * _moveSpeed);
            RenderImage();
        }

        private void MoveButtonDownClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Point.up * _moveSpeed);
            RenderImage();

        }

        private void MoveButtonRightClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Point.right * _moveSpeed);
            RenderImage();
        }

        private void ObjectFollow()
        {
            Point cursorPosition = Point.ToPoint(_pictureBox.PointToClient(Cursor.Position));
            if (_clickedObject == null)
            {
                return;
            }
            _space.TryMoveObject(_clickedObject, cursorPosition - _clickedObject.Position - _clickedObject.Size / 2);
            RenderImage();
        }

        private Object? GetObjectByPoint(Point position)
        {
            return _space.GetObjectByPoint(position);
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            Point cursorPosition = Point.ToPoint(_pictureBox.PointToClient(Cursor.Position));
            _clickedObject = GetObjectByPoint(cursorPosition);
            _timer.Enabled = true;
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _timer.Enabled = false;
            _clickedObject = null;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            ObjectFollow();
        }
    }
}
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
            _objects.Add(new Cirle(new Vector2(100, 100), new Vector2(100, 100)));
            _objects.Add(new Square(new Vector2(300, 300), new Vector2(100, 100)));

            _space = new(_objects, new Vector2(_pictureBox.Size.Width, _pictureBox.Size.Height));

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
            _space.TryMoveObject(selectedObject, Vector2.down * _moveSpeed);
            RenderImage();
        }

        private void MoveButtonLeftClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Vector2.left * _moveSpeed);
            RenderImage();
        }

        private void MoveButtonDownClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Vector2.up * _moveSpeed);
            RenderImage();

        }

        private void MoveButtonRightClick(object sender, EventArgs e)
        {
            _space.TryMoveObject(selectedObject, Vector2.right * _moveSpeed);
            RenderImage();
        }

        private void ObjectFollow()
        {
            Vector2 cursorPosition = Vector2.ToVector2(_pictureBox.PointToClient(Cursor.Position));
            if (_clickedObject == null)
            {
                return;
            }
            _space.TryMoveObject(_clickedObject, cursorPosition - _clickedObject.Position - _clickedObject.Size / 2);
            RenderImage();
        }

        private Object? GetObjectByVector2(Vector2 position)
        {
            return _space.GetObjectByVector2(position);
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            Vector2 cursorPosition = Vector2.ToVector2(_pictureBox.PointToClient(Cursor.Position));
            _clickedObject = GetObjectByVector2(cursorPosition);
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
using SpaceLibriry;
using Object = SpaceLibriry.Object;

public partial class Form1 : Form
{
    private Object? _clickedObject;
    private List<IRenderable> _renderables = new();
    private List<Object> _dots = new();
    private Point[] _bezieDots;
    private Space _space;
    private BezieCurve _curve;

    public Form1()
    {
        InitializeComponent();

        _dots.Add(new Dot(new Point(_pictureBox.Size.Width / 2 + 100, _pictureBox.Size.Height / 2 - 100)));
        _dots.Add(new Dot(new Point(_pictureBox.Size.Width / 2 + 100, _pictureBox.Size.Height / 2 + 100)));
        _dots.Add(new Dot(new Point(_pictureBox.Size.Width / 2 - 100, _pictureBox.Size.Height / 2 + 100)));
        _dots.Add(new Dot(new Point(_pictureBox.Size.Width / 2 - 100, _pictureBox.Size.Height / 2 - 100)));
        _dots.Add(new Dot(new Point(_pictureBox.Size.Width / 2 - 150, _pictureBox.Size.Height / 2 - 150)));

        _renderables.AddRange(_dots);

        _bezieDots = new Point[_dots.Count];
        _curve = new BezieCurve(_bezieDots);
        _renderables.Add(_curve);

        _space = new(_renderables, (Point)_pictureBox.Size);
    }

    private void Render()
    {
        _pictureBox.Image = _space.Render();
    }

    private void ObjectFollow()
    {
        Point cursorPosition = _pictureBox.PointToClient(Cursor.Position);
        if (_clickedObject == null)
        {
            return;
        }
        _space.TryMoveObject(_clickedObject, new Point(cursorPosition.X - _clickedObject.Position.X, cursorPosition.Y - _clickedObject.Position.Y));
    }

    private Object? GetObjectByPoint(Point position)
    {
        return _space.GetObjectByPoint(position);
    }

    private void PictureBoxMouseDown(object sender, MouseEventArgs e)
    {
        Point cursorPosition = _pictureBox.PointToClient(Cursor.Position);
        _clickedObject = GetObjectByPoint(cursorPosition);
    }

    private void PictureBoxMouseUp(object sender, MouseEventArgs e)
    {
        _clickedObject = null;
    }

    private void TimerTick(object sender, EventArgs e)
    {
        ObjectFollow();
        for (int i = 0; i < _bezieDots.Length; i++)
        {
            _bezieDots[i] = _dots[i].Position;
        }
        Render();
    }

    private void TrackBarOnScroll(object sender, EventArgs e)
    {
        float currentValue = trackBar1.Value / 100f;
         _curve.DebugCoefficient = currentValue;
        _coefficientTextBox.Text = currentValue.ToString();
    }

    private void DebugOnCheckedChanged(object sender, EventArgs e)
    {
        _curve.DebugMode = _debug.Checked;
    }
}
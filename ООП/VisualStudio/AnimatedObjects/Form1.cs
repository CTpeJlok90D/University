using MovebleObjects;
using Object = MovebleObjects.Object;

namespace AnimatedObjects
{
    public partial class Form1 : Form
    {
        private Space _space;
        private List<Object> _objects = new();
        private Animation _animation;
        private Object _object;

        public Form1()
        {
            InitializeComponent();
            _object = new Square(new Vector2(100, 100), new Vector2(100, 100));
            _objects.Add(_object);
            _space = new Space(_objects, new Vector2(pictureBox1.Width, pictureBox1.Height));
            RenderImage();
            _animation = new Animation(new List<Vector2>()
            {
                new Vector2(100,100),
                new Vector2(300,100),
                new Vector2(300,300),
                new Vector2(100,300)
            }, 0.01f);
            _animationTimer.Enabled = true;
        }

        private void RenderImage()
        {
            pictureBox1.Image = _space.Render();
        }

        private void AnimationTtimerTick(object sender, EventArgs e)
        {
            _animation.OnTick();
            _object.SetPosition(_animation.CurrentPoint);
            RenderImage();
            if (_animation.IsFinished)
            {
                _animationTimer.Enabled = false;
            }
        }
    }
}
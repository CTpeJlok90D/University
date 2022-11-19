using MovebleObjects;
using PlanetSystem;
using SpaceLibriry;
using Object = MovebleObjects.Object;

namespace AnimatedObjects
{
    public partial class Form1 : Form
    {
        private Space _space;
        private List<Object> _objects = new();
        private Object _object;
        private ElliplceAnimation _ellicpceAnimation;
        private Point Center => new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);

        public Form1()
        {
            InitializeComponent();
            _object = new Eartch(new Point(0, 0));
            _objects.Add(_object);
            _objects.Add(new Star(Center, new Point(100, 100)));
            _space = new Space(_objects, new Point(pictureBox1.Width, pictureBox1.Height));
            RenderImage();

            _ellicpceAnimation = new(Center, 180, 150);

            _animationTimer.Enabled = true;
        }

        private void RenderImage()
        {
            pictureBox1.Image = _space.Render();
        }

        private void AnimationTtimerTick(object sender, EventArgs e) 
        {
            _ellicpceAnimation.OnTick();
            _object.Position = _ellicpceAnimation.CurrentPoint;
            RenderImage();
        }
    }
}
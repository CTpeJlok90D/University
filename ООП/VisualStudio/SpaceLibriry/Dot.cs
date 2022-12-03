using System.Drawing;

namespace SpaceLibriry
{
    public class Dot : Object
    {
        private Brush _brush = new SolidBrush(Color.Black);

        public Dot(Point position) : base(position, new Point(8, 8)) { }
        public Dot(Point position, Point size) : base(position, size)
        {

        }
        public Dot(Point position, Brush brush, Point size) : base(position, size)
        {
            _brush = brush;
        }
        

        public override void RenderOn(Graphics graphics)
        {
            graphics.FillEllipse(_brush, 
                                 new Rectangle(new Point(Position.X - Size.X/2, Position.Y - Size.Y/2), 
                                 new Size(Size.X, Size.Y)));
        }
    }
}

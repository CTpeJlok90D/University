using System.Drawing;

namespace SpaceLibriry
{
    public class Square : Object
    {
        public override string Name => "Square";
        public Square(Point position, Point size) : base(position, size){}

        public override void RenderOn(Graphics graphics)
        {
            graphics.DrawLines(
                new Pen(new SolidBrush(Color.Black)),
                new Point[] 
                    {
                        new Point(Position.X,Position.Y),
                        new Point(Position.X, Size.Y + Position.Y),
                        new Point(Size.X + Position.X, Size.Y + Position.Y),
                        new Point(Size.X + Position.X, Position.Y),
                        new Point(Position.X,Position.Y)
                    }
                );
        }
    }
}

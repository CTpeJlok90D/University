using System.Drawing;

namespace MovebleObjects
{
    public class Cirle : Object
    {
        public Cirle(Point position, Point size) : base(position, size) { }
        public override string Name => "Circle";

        public override void RenderOn(Graphics graphics)
        {
            graphics.DrawEllipse(
                new Pen(new SolidBrush(Color.Black)),
                new Rectangle(
                    Position.X,
                    Position.Y,
                    Size.X,
                    Size.Y)
                );
        }
    }
}

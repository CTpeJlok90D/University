using System.Drawing;

namespace MovebleObjects
{
    public class Square : Object
    {
        public override string Name => "Square";
        public Square(Vector2 position, Vector2 size) : base(position, size){}

        public override void RenderOn(Graphics graphics)
        {
            graphics.DrawLines(
                new Pen(new SolidBrush(Color.Black)),
                new Point[] 
                    {
                        new Point(Position.x,Position.y),
                        new Point(Position.x, Size.y + Position.y),
                        new Point(Size.x + Position.x, Size.y + Position.y),
                        new Point(Size.x + Position.x, Position.y),
                        new Point(Position.x,Position.y)
                    }
                );
        }
    }
}

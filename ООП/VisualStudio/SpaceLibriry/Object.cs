using System.Drawing;

namespace MovebleObjects
{
    public abstract class Object : IRenderable
    {
        public Point Position { get; set; }
        public Point Size { get; private set; }
        public virtual string Name => "UnnamedObject";

        public Object(Point position, Point size)
        {
            Position = position;
            Size = size;
        }

        public void Move(Point offcet)
        {
            Position = new Point(Position.X + offcet.X, Position.Y + offcet.Y);
        }

        public void SetPosition(Point newPosition)
        {
            Position = newPosition;
        }

        public bool HaveThisCords(Point position)
        {
            return position.X < Size.X + Position.X && position.Y < Size.Y + Position.Y
                && position.X > Position.X && position.Y > Position.Y;
        }

        public abstract void RenderOn(Graphics graphics);
    }
}

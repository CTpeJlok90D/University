using System.Drawing;

namespace SpaceLibriry
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
            return position.X < Size.X / 2 + Position.X && position.Y < Size.Y / 2 + Position.Y
                && position.X > Position.X - Size.X / 2 && position.Y > Position.Y - Size.Y / 2;
        }

        public abstract void RenderOn(Graphics graphics);
    }
}

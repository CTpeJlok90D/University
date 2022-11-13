using System.Drawing;

namespace MovebleObjects
{
    public abstract class Object : IRenderable
    {
        public Vector2 Position { get; set;}
        public Vector2 Size { get; private set; }
        public virtual string Name => "UnnamedObject";

        public Object(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }

        public void Move(Vector2 offcet)
        {
            Position += offcet;
        }

        public void SetPosition(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public bool HaveThisCords(Vector2 position)
        {
            return position.x < Size.x + Position.x && position.y < Size.y + Position.y 
                && position.x > Position.x && position.y > Position.y;
        }

        public abstract void RenderOn(Graphics graphics);
    }
}

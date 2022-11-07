namespace MovebleObjects
{
    internal abstract class Object : IRenderable
    {
        public Vector2 Position { get; private set; }
        public Vector2 Size { get; private set; }
        public virtual string Name => "UnnamedObject";

        public Object(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }

        public void Move(Vector2 direction)
        {
            Position += direction;
        }

        public abstract void RenderOn(Graphics graphics);
    }
}

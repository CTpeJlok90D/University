namespace MovebleObjects
{
    internal class Cirle : Object
    {
        public Cirle(Vector2 position, Vector2 size) : base(position, size) { }
        public override string Name => "Circle";

        public override void RenderOn(Graphics graphics)
        {
            graphics.DrawEllipse(
                new Pen(new SolidBrush(Color.Black)),
                new Rectangle(
                    Position.x,
                    Position.y,
                    Size.x,
                    Size.y)
                );
        }
    }
}

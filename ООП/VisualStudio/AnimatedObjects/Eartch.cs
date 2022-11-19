
namespace PlanetSystem
{
    internal class Eartch : MovebleObjects.Object
    {
        public Eartch(Point position) : base(position, new Point(50, 50))
        {
        }

        public override void RenderOn(Graphics graphics)
        {
            SolidBrush solidBrush = new(Color.Aqua);
            graphics.FillEllipse(solidBrush, new Rectangle(new Point(Position.X - Size.X/2, Position.Y - Size.Y/2), new Size(Size)));
            graphics.FillPolygon(new SolidBrush(Color.Green), new Point[]
            {
                new Point(Position.X - 5, Position.Y),
                new Point(Position.X - 9, Position.Y - 5),
                new Point(Position.X - 14, Position.Y - 10),
                new Point(Position.X - 3, Position.Y - 17),
            });

            graphics.FillPolygon(new SolidBrush(Color.Green), new Point[]
            {
                new Point(Position.X - 5, Position.Y + 1),
                new Point(Position.X - 2, Position.Y + 14),
                new Point(Position.X - 18, Position.Y + 4),
                new Point(Position.X - 16, Position.Y + 12),
            });
        }
    }
}

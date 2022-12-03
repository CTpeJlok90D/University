using Object = SpaceLibriry.Object;

namespace PlanetSystem
{
    internal class Star : Object
    {
        int _vertexCount = 60;
        float _insideRadius = 45;
        float _outsideRadius = 50;

        public Star(Point position, Point size, int vertexCount = 50, float insideRadius = 45, float outsideRadius = 50) : base(position, size)
        {
            _vertexCount = vertexCount;
            _insideRadius = insideRadius;
            _outsideRadius = outsideRadius;
        }

        public override void RenderOn(Graphics graphics)
        {
            SolidBrush solidBrush = new(Color.Yellow);     

            List<Point> lights = new();
            float currentAlpha = 0;
            float da = MathF.PI / _vertexCount;
            float radiusChanger;

            for (int i = 0; i < 2 * _vertexCount + 1; i++)
            {
                radiusChanger = i % 2 == 0 ? _outsideRadius : _insideRadius;
                lights.Add(new Point((int)(Position.X + radiusChanger * MathF.Cos(currentAlpha)), (int)(Position.Y + radiusChanger * MathF.Sin(currentAlpha))));
                currentAlpha += da;
            }

            graphics.FillPolygon(solidBrush, lights.ToArray());
        }
    }
}

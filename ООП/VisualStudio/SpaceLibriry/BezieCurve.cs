using System.Drawing;

namespace SpaceLibriry
{
    public class BezieCurve : IRenderable
    {
        public bool DebugMode;

        private float _debugCoefficient = 0.5f;
        private Point[] _dots;

        public float DebugCoefficient 
        {
            get
            {
                return _debugCoefficient;
            }
            set
            {
                if (value > 1)
                {
                    _debugCoefficient = 1;
                    return;
                }
                if (value < 0)
                {
                    _debugCoefficient = 0;
                }
                _debugCoefficient = value;
            }
        }

        public BezieCurve(Point[] dots)
        {
            _dots = dots;
        }

        public void RenderOn(Graphics graphics)
        {
            if (DebugMode)
            {
                DrawDebugLines(graphics);
            }

            DrawCurve(graphics);
        }

        private void DrawDebugLines(Graphics graphics)
        {
            List<Point> pointList = new(_dots);
            while (pointList.Count != 1)
            {
                graphics.DrawLines(new Pen(Color.Gray),pointList.ToArray());
                List<Point> newPointList = new();
                for (int j = 1; j < pointList.Count; j++)
                {
                    newPointList.Add(MathOperations.Lerp(pointList[j], pointList[j - 1], _debugCoefficient));
                }
                pointList = new(newPointList);
                foreach (Point point in pointList)
                {
                    graphics.FillEllipse(new SolidBrush(Color.Gray), new Rectangle(new Point(point.X - 4, point.Y - 4), new Size(8, 8)));
                }
            }
        }

        private void DrawCurve(Graphics graphics)
        {
            List<Point> drawPoints = new();
            for (float i = 0; i <= 1; i += 0.01f)
            {
                List<Point> pointList = new(_dots);
                while (pointList.Count != 1)
                {
                    List<Point> newPointList = new();
                    for (int j = 1; j < pointList.Count; j++)
                    {
                        newPointList.Add(MathOperations.Lerp(pointList[j], pointList[j - 1], i));
                    }
                    pointList = new(newPointList);
                }
                drawPoints.Add(pointList[0]);
            }
            graphics.DrawLines(new Pen(Color.Black), drawPoints.ToArray());
        }
    }
}

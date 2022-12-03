using System.Drawing;

namespace SpaceLibriry
{
    public class BezieLine : IRenderable
    {
        private Point[] _dots;

        public BezieLine(Point[] dots)
        {
            _dots = dots;
        }

        public void RenderOn(Graphics graphics)
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
                        newPointList.Add(MathOperations.Lerp(pointList[j], pointList[j-1], i));
                    }
                    pointList = new(newPointList);
                }
                drawPoints.Add(pointList[0]);
            }
            graphics.DrawLines(new Pen(Color.Black), drawPoints.ToArray());
        }
    }
}

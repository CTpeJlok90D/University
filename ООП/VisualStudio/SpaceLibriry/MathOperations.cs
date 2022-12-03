using System.Drawing;

namespace SpaceLibriry
{
    public static class MathOperations
    {
        public static Point Lerp(Point pointA, Point pointB, float coefficient)
        {
            return new Point
                ((int)Lerp(pointA.X, pointB.X, coefficient), (int)Lerp(pointA.Y, pointB.Y, coefficient));
        }

        public static float Lerp(int A, int B, float coefficient)
        {
            return A * (1 - coefficient) + B * coefficient;
        }
    }
}

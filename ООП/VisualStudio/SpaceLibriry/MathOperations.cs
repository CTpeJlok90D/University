namespace MovebleObjects
{
    public static class MathOperations
    {
        public static Vector2 Lerp(Vector2 pointA, Vector2 pointB, float coefficient)
        {
            return new Vector2
                ((int)Lerp(pointA.x, pointB.x, coefficient), (int)Lerp(pointA.y, pointB.y, coefficient));
        }

        public static float Lerp(int A, int B, float coefficient)
        {
            return A * (1 - coefficient) + B * coefficient;
        }
    }
}

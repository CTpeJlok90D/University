using System.Drawing;

namespace MovebleObjects
{
    public struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 up => new Vector2(0,1);
        public static Vector2 down => new Vector2(0,-1);
        public static Vector2 right => new Vector2(1,0);
        public static Vector2 left => new Vector2(-1,0);
        public static Vector2 zero => new Vector2(0, 0);

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static bool operator == (Vector2 a, Vector2 b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return a.x != b.x || a.y != b.y;
        }

        public static Vector2 operator *(Vector2 a, int b)
        {
            return new Vector2(a.x * b, a.y * b);
        }

        public static Vector2 operator /(Vector2 a, int b)
        {
            return new Vector2(a.x / b, a.y / b);
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }

        public static Vector2 ToVector2(Size size)
        {
            return new Vector2(size.Width, size.Height);
        }
        
        public static Vector2 ToVector2(Point point)
        {
            return new Vector2(point.X, point.Y); 
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            Vector2 vector2 = (Vector2)obj;
            return vector2.x == x && vector2.y == y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

using System.Drawing;

namespace SpaceLibriry
{
    public class ElliplceAnimation : IAnimation
    {
        private int _height, _width;
        private Point _center;
        private int _xStep;

        private int _currentX = 0;
        private int _yMultiply = 1;

        public ElliplceAnimation(Point center, int wight, int height, int xStep = 1)
        {
            _center = center;
            _width = wight;
            _height = height;
            _xStep = xStep;
            _currentX = -wight;
        }

        public Point CurrentPoint => new Point(_currentX + _center.X, CalculateY(_currentX) * _yMultiply + _center.Y);
        private int CalculateY(int x) => (int)MathF.Sqrt((1 - MathF.Pow(x, 2) / MathF.Pow(_width, 2)) * MathF.Pow(_height, 2));
        
        public void OnTick()
        {
            Console.WriteLine($"{_currentX} {CurrentPoint.X} {CurrentPoint.Y}");
            _currentX += _xStep;
            if (MathF.Abs(_currentX) >= _width)
            {
                _xStep *= -1;
                _yMultiply *= -1;
            }
        }
    }
}

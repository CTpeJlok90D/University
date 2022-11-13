namespace MovebleObjects
{
    public class Animation
    {
        private List<Vector2> _points;
        private int _currentPointndex = 1;
        private float _stepPerTick;
        private float _currentLerpCoefficient = 0;

        public bool IsFinished { get; private set; }
        public Vector2 CurrentPoint { get; private set; }

        public Animation(List<Vector2> points, float stepPerTick = 0.1f)
        {
            _points = points;
            _stepPerTick = stepPerTick;
        }

        public void OnTick()
        {
            if (IsFinished)
            {
                return;
            }
            if (_currentLerpCoefficient > 1)
            {
                NextPoint();
            }
            if (_currentPointndex >= _points.Count)
            {
                IsFinished = true;
                return;
            }
            CurrentPoint = MathOperations.Lerp(_points[_currentPointndex - 1], _points[_currentPointndex], _currentLerpCoefficient);
            _currentLerpCoefficient += _stepPerTick;
        }

        private void NextPoint()
        {
            _currentLerpCoefficient = 0;
            _currentPointndex++;
        }
    }
}

namespace ColoredBar
{
    public partial class ColoredProgressBar : UserControl
    {
        private int _value;
        private int _maxValue = 100;
        private int _minValue = 0;
        private Color _currentColor = Color.Red;
        private Color _backGroundColor = new();

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = Math.Clamp(value, _minValue, _maxValue);
                UpdateColor();
                UpdateView();
            }
        }

        public Color BackGroundColor
        {
            get
            {
                return _backGroundColor;
            }
            set
            {
                _backGroundColor = value;
                UpdateView();
            }
        }

        public int MaxValue => _maxValue;
        public int MinValue => _minValue;

        private float procentFill =>  _value / 100f;

        public ColoredProgressBar()
        {
            InitializeComponent();
        }

        private void UpdateColor()
        {
            int redColorCount = (int)Math.Round(procentFill * 255);
            int greenColorCount = (int)Math.Round((1d - procentFill) * 255d);
            _currentColor = Color.FromArgb(redColorCount, greenColorCount , 0);
        }

        private void UpdateView()
        {
            Image image = new Bitmap(_picture.Width, _picture.Height);
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(_currentColor);
            SolidBrush brush = new SolidBrush(_backGroundColor);
            graphics.FillPolygon(brush, new Point[] 
            {
                new(0,0), 
                new(_picture.Width,0), 
                new(_picture.Width, (int)(_picture.Height * (1 - procentFill))),  
                new(0, (int)(_picture.Height * (1 - procentFill)))
            });

            _picture.Image = image;
        }
    }
}

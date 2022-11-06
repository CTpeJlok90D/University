namespace Stopwatch
{
    public partial class OOPN1 : Form
    {
        private float _time = 0;
        public OOPN1()
        {
            InitializeComponent();
        }

        private void OnStartButtonClick(object sender, EventArgs e)
        {
            _timer.Interval = (int)_intervalTextBox.Value * 1000;
            _timer.Start();
        }

        private void OnStopButtonClick(object sender, EventArgs e)
        {
            _timer.Stop();
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeTextBox.Text = "0";
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _time += _timer.Interval / 1000;
            _timeTextBox.Text = _time.ToString();
        }
    }
}
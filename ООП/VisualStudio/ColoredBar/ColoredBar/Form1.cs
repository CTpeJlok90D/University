namespace ColoredBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (TryParse(out int value))
            {
                coloredBar.Value = value;
            }
        }

        private bool TryParse(out int value)
        {
            try
            {
                value = int.Parse(valueTextBox.Text);
                if (value > coloredBar.MaxValue || value < coloredBar.MinValue)
                {
                    MessageBox.Show("�������� ������ ���� � ��������� ���������(�����������):\n0:100", "������",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("�� ������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = 0;
                return false;
            }
        }
    }
}
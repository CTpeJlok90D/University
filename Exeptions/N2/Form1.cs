using System;
using System.Windows.Forms;

namespace N2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateClick(object sender, EventArgs e)
        {
            double aValue,bValue,cValue;
            try
            {
                aValue = Convert.ToDouble(inputA.Text);
                bValue = Convert.ToDouble(inputB.Text);
                cValue = Convert.ToDouble(inputC.Text);
            }
            catch
            {
                MessageBox.Show("Введённые данные - не цифры");
                return;
            }

            if (aValue == 0)
            {
                MessageBox.Show("Это не квадратное уравнение");
                return;
            }

            double discriminant = Math.Pow(bValue, 2) + 4 * aValue * cValue;

            if (discriminant < 0)
            {
                MessageBox.Show("Решений нет");
                return;
            }

            result1.Text = Convert.ToString((-bValue + Math.Sqrt(discriminant)) / 2 * aValue);
            result2.Text = Convert.ToString((-bValue - Math.Sqrt(discriminant)) / 2 * aValue);
        }
    }
}

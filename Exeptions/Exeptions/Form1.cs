using System;
using System.Windows.Forms;

namespace Exeptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal valueA = TryReadValue(InputA, "Ты зачем буквы делишь?");
            decimal valueB = TryReadValue(InputB, "Ты зачем на буквы делишь?");

            Result.Text = TryDivision(valueA, valueB, "Ай да хватит вселенную ломать").ToString();
        }

        private decimal TryReadValue(TextBox textBox, string errorMessage)
        {
            decimal value = 1;
            try
            {
                return Convert.ToDecimal(textBox.Text);
            }
            catch (FormatException exeption)
            {
                MessageBox.Show(errorMessage);
            }
            return value;
        }

        private decimal TryDivision(decimal valueA, decimal valueB, string errorMessage)
        {
            try
            {
                return valueA / valueB;
            }
            catch (DivideByZeroException exeption)
            {
                MessageBox.Show(errorMessage);
            }
            return 1;
        }
    }
}

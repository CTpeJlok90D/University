using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = Convert.ToInt32(input.Text);
            }
            catch
            {
                MessageBox.Show("Это не цифра");
                return;
            }

            int i = 0;
            try
            {
                for (i = 0; true; i++)
                {
                    if (i == a)
                    {
                        throw new Exception("А?");
                    }
                }
            }
            catch
            {
                result.Text = Convert.ToString(i);
                return;
            }
        }
    }
}

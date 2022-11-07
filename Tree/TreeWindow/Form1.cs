using Tree;

namespace TreeWindow
{
    public partial class Form1 : Form
    {
        private FloatBinarTree? Tree;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            float readenValue = TryReadValue(addTextBox);
            if (readenValue == float.NaN)
            {
                return;
            }
            if (Tree == null)
            {
                Tree = new(readenValue);
            }
            else
            {
                Tree.Add(readenValue);
            }
            addTextBox.Text = "";
            treeViewTextBox.Text = Tree.ToString();
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            float readenValue = TryReadValue(addTextBox);
            if (readenValue == float.NaN)
            {
                return;
            }

            if (Tree == null)
            {
                MessageBox.Show("������ �� �������");
                return;
            }

            FloatBinarTreeBranch? foundBranch = Tree.FindBranch(readenValue);
            //if (foundBranch == null)
            //{
            //    MessageBox.Show("�������� �� �������");
            //    return;
            //}
            foundBranch.RemoveSelf();
        }

        private float TryReadValue(TextBox textBox)
        {
            try
            {
                return float.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("�� ����� ������������ ��������");
                return float.NaN;
            }
        }
    }
}
using L6;
namespace StackForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MyStack<int> stack;
        private void Push_Click(object sender, EventArgs e)
        {
            try
            {
                int item = int.Parse(textBox1.Text);
                stack.Push(item);
                richTextBox1.Text = stack.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка"+ err.Message);
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                stack = new MyStack<int>();
            }
            else
            {
                int size = Convert.ToInt32(textBox2.Text);
                stack = new MyStack<int>(size);
            }
        }

        private void Peek_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text=stack.Peek().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }

        private void Pop_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Pop();
                richTextBox1.Text = stack.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }
    }
}
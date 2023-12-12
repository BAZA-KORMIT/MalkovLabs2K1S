using AlgosLab8;
namespace ProjForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MyDeque<int> deq;
        

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                deq.AddFirst(int.Parse(textBox3.Text));
                richTextBox1.Text = deq.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            try
            {
                deq.AddLast(int.Parse(textBox2.Text));
                richTextBox1.Text = deq.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                deq.RemoveFirst();
                richTextBox1.Text = deq.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                deq.RemoveLast();
                richTextBox1.Text = deq.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
                deq = new MyDeque<int>();
            else
                deq = new MyDeque<int>(int.Parse(textBox1.Text));
        }
    }
}
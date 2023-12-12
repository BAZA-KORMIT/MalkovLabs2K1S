using AlgosLab7;
using System.Collections.Generic;

namespace QForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MyQueue<int> Q;
        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    Q = new MyQueue<int>();
                }
                else
                {
                    int size = Convert.ToInt32(textBox1.Text);
                    Q = new MyQueue<int>(size);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }

        private void Enq_Click(object sender, EventArgs e)
        {
            try
            {
                Q.Enqueue(Convert.ToInt32(textBox2.Text));
                richTextBox1.Text=Q.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }

        private void Deq_Click(object sender, EventArgs e)
        {
            try
            {
                Q.Dequeue();
                richTextBox1.Text = Q.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                Q.Clear();
                richTextBox1.Text = Q.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }

        private void Peek_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Q.Peek().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка" + err.Message);
            }
        }
    }
}
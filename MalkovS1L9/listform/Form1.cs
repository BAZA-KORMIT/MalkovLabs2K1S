using lab9;
using System.Windows.Forms;


namespace listform
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public MyList<int> list =new MyList<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(int.Parse(textBox4.Text));
                richTextBox1.Text = list.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("ошибка" + err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.IsEmpty)
                    throw new ArgumentException("Список пуст");
                list.Removelast();
                richTextBox1.Text = list.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("ошибка " + err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text=="")
                    throw new ArgumentException("Не выбран элемент который необходимо убрать");
                list.Remove(int.Parse(textBox1.Text));
                richTextBox1.Text = list.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("ошибка " + err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                list.Clear();
                richTextBox1.Text = list.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("ошибка " + err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MyList<int> list2 = new MyList<int>(int.Parse(textBox2.Text));
                for (int i = 0; i < int.Parse(textBox2.Text); i++)
                {
                    list2.Add(random.Next(1, 10));
                }
                richTextBox2.Text = list2.ToString();
                list.MergeList(list2);
                richTextBox1.Text = list.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("ошибка " + err.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = richTextBox3.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (str.Length == 0)
                    throw new ArgumentException("Лист-парсер пустой");
                MyList<int> listparse = new MyList<int>(str.Length);
                for (int i = 0; i < str.Length; i++)
                {
                    listparse.Add(int.Parse(str[i]));
                }
                int c = int.Parse(textBox3.Text);
                if (c > list.Count)
                    throw new ArgumentException("Нельзя скопировать столько элементов");
                list.Copy(c, listparse);
                richTextBox1.Text = list.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show("ошибка: "+err.Message);
            }
        }
    }
}
using Malkov2KLab6_9;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Тест стэка\n");
            TestStack();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Тест очереди\n");
            TestQueue();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Тест списка\n");
            TestList();
        }

        static void TestList()
        {
            MyLinkedList<string> linkedList = new MyLinkedList<string>();
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("John");
            linkedList.Add("Marry");


            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList.Remove("Alice");
            Console.WriteLine("\nПосле удаления Alice");
            foreach (var item in linkedList) Console.WriteLine(item);

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Bill");
            Console.WriteLine("\nПосле добавления Billa");
            foreach (var item in linkedList) Console.WriteLine(item);
        }

        static void TestQueue()
        {
            MyQueue2<int> queue = new MyQueue2<int>();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            foreach (int item in queue)
            {
                Console.WriteLine(queue.Remove());
            }

        }

        static void TestStack()
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Add(1);
            stack.Add(2);
            stack.Add(3);

            Console.WriteLine("Верхний элемент стека: " + stack.Peek());
            Console.WriteLine("Удален элемент: " + stack.Remove());
            Console.WriteLine("Новый верхний элемент стека: " + stack.Peek());
            Console.WriteLine("Удален элемент: " + stack.Remove());
            Console.WriteLine("Новый верхний элемент стека: " + stack.Peek());
            Console.WriteLine("Удален элемент: " + stack.Remove());
        }
    }
}

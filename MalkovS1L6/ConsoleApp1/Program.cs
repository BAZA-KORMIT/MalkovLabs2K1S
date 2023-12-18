using AlgosLab6;
class Program
{
    static void Main(string[] args)
    {
        MyStack2<int> stack = new MyStack2<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);


        Console.WriteLine("Верхний элемент стека: " + stack.Peek());
        Console.WriteLine("Удален элемент: " + stack.Pop());
        Console.WriteLine("Новый верхний элемент стека: " + stack.Peek());
        Console.WriteLine("Удален элемент: " + stack.Pop());
        Console.WriteLine("Новый верхний элемент стека: " + stack.Peek());
        Console.WriteLine("Удален элемент: " + stack.Pop());

        
    }
}
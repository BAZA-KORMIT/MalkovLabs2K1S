using System;
using System.Collections.Generic;
namespace L6
{
    class L6
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите размер стека");
                int size = Convert.ToInt32(Console.ReadLine());
                MyStack<int> stack = new MyStack<int>(size);
                while (true)
                {
                    Console.WriteLine("\nвведите num");
                    Console.WriteLine("1add\n2peek\n3read\n4isEmpty?\n5Exit");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("выберите число,которое хотите добавить");
                            int n = Convert.ToInt32(Console.ReadLine());
                            stack.Push(n);
                            break;
                        case 2:
                            Console.WriteLine(stack.Peek());
                            break;
                        case 3:
                            Console.WriteLine(stack.ToString());
                            break;
                        case 4:
                            if (!stack.IsEmpty())
                                Console.WriteLine("стек не пустой");
                            else
                                Console.WriteLine("стек пустой");
                            break;
                        case 5:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Введено не то число");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ошибка ввода");
            }

        }
    }
    public class MyStack<T>
    {
        private T[] elements;
        private int top;
        private int Size;

        public MyStack(int Size)
        {
            this.Size = Size;
            this.top = 0;
            this.elements = new T[this.Size];
        }
        public MyStack():this(12)
        {
            
        }
        public int Top
        {
            get
            {
                return this.top;
            }
        }
        public int size
        {
            get
            {
                return this.Size;
            }
        }
        public int Count
        {
            get
            {
                return this.top;
            }
        }
        public bool isFull()
        {
            return this.top == this.size;
        }
        public void Push(T item)
        {
            if (this.isFull())
                throw new Exception("Стек переполнен");
            this.elements[this.top++] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Стек пуст");
            return this.elements[--this.top];
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Стек пуст");
            return this.elements[this.top-1];
        }
        
        public bool IsEmpty()
        {
            return this.top == 0;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Top; i++)
                result += elements[i]+ " ";
            return result;
        }
    }

}
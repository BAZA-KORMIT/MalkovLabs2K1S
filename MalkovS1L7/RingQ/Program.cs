using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgosLab7
{
    public class RingQ<T>
    {
        int size;
        int front;int rear;
        T[] items;
        public RingQ(int size)
        {
            front = -1;
            rear = -1;
            items = new T[size];
        }
        public bool isFull()
        {
            if (front == 0 && rear == size - 1)
            {
                return true;
            }
            if (front == rear + 1)
            {
                return true;
            }
            return false;
        }
        public bool IsEmpty => front == -1;
        public void enqueue(T element)
        {
            if (isFull())
            {
                Console.WriteLine("Очередь заполнена");
            }
            else
            {
                if (front == -1)
                    front = 0;
                rear = (rear + 1) % size;
                items[rear] = element;
                Console.WriteLine("Добавлено значение " + element);
            }
        }
        public T dequeue()
        {
            T element;
            if (IsEmpty)
            {
                Console.WriteLine("Очередь пуста");
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                element = items[front];
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                } /*  Внутри Q только один элемент, поэтому очередь сбрасывается
           в начальное состояние после удаления последнего элемента */
                else
                {
                    front = (front + 1) % size;
                }
                return element;
            }
        }

    }
    class prog
    {
        static void Main()
        {
            
        }
    }
}


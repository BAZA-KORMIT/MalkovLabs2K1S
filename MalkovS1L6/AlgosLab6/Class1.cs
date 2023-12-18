using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosLab6
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class MyStack2<T>
    {
        private Node<T> top;

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>
            {
                Data = item,
                Next = top
            };
            top = newNode;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пустой");

            T item = top.Data;
            top = top.Next;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пустой");

            return top.Data;
        }

        public bool IsEmpty => top == null;
    }
}

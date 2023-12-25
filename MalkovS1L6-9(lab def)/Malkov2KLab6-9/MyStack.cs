using System.Collections;

namespace Malkov2KLab6_9
{
    public class MyStack<T> : IMovement<T>
    {
        private Node<T> top;
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item)
            {
                Data = item,
                Next = top
            };
            top = newNode;
        }

        public T Remove()
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

        public bool isEmpty() => top == null;
        public bool IsEmpty => top == null;
    }
}

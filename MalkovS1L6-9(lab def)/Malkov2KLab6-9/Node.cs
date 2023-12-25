using System;
namespace Malkov2KLab6_9
{
    public class Node<T>
    {
        public Node(T data){ Data = data; }
        public T Data { get; set; }
        public Node<T>? Next { get; set; }
    }
}


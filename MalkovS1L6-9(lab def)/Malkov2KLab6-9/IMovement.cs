using System;
namespace Malkov2KLab6_9
{
    public interface IMovement<T>
    {
        void Add(T data);
        T Remove();
        bool isEmpty();
    }

}


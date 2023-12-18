using System.Collections;

namespace AlgosLab7
{
    public class MyQueue<T>
    {
        private int head;
        private int tail ;
        private int _Count ;
        private readonly int _Size;
        private readonly T[] _Array;
        public MyQueue(int Size)
        {
            this._Size = Size;
            this._Array = new T[Size];
        }
        public MyQueue():this(12)
        {
            
        }
        public bool IsEmpty => _Count == 0;
        public bool IsFull => tail == _Size-1;
        public void Enqueue(T item)
        {
            if (this.IsFull)
                throw new Exception("Очередь заполнена.");
            _Array[tail++] = item;
            _Count++;
        }
        public T Dequeue()
        {
            if (this.IsEmpty)
                throw new Exception("Очередь не заполнена.");
            T value = _Array[++head];
            _Count--;
            if (head == tail)
            {
                head = -1;
                tail = -1;
            }
            return value;
           
        }
        public T Peek()
        {
            if (this.IsEmpty)
                throw new Exception("Очередь не заполнена.");
            T value = _Array[head + 1];
            return value;
        }
        public int Size => _Size;
        public int Count => _Count;
        public void Clear()
        {
            head = 0;
            tail = 0;
            _Count = 0;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
                result += _Array[i] + " ";
            return result;
        }
        
    }
}
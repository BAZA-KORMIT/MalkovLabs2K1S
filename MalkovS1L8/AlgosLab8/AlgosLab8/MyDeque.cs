using System.Collections;


namespace AlgosLab8
{
    

    /*public class MyDeque<T>
    {
        private T[] array;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public MyDeque(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
            front = -1;
            rear = 0;
            size = 0;
        }
        public MyDeque() : this(12)
        {

        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public int GetSize()
        {
            return size;
        }

        public void AddFirst(T item)
        {
            if (IsFull())
            {
                throw new Exception("Deque is full");
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
            {
                front = capacity - 1;
            }
            else
            {
                front = front - 1;
            }

            array[front] = item;
            size++;
        }

        public void AddLast(T item)
        {
            if (IsFull())
            {
                throw new Exception("Deque is full");
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (rear == capacity - 1)
            {
                rear = 0;
            }
            else
            {
                rear = rear + 1;
            }

            array[rear] = item;
            size++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new Exception("Deque is empty");
            }

            T item = array[front];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == capacity - 1)
            {
                front = 0;
            }
            else
            {
                front = front + 1;
            }

            size--;
            return item;
        }

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                throw new Exception("Deque is empty");
            }

            T item = array[rear];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
            {
                rear = capacity - 1;
            }
            else
            {
                rear = rear - 1;
            }

            size--;
            return item;
        }

        public override string ToString()
        {
            string res = "";
            foreach(T item in array)
            {
                res += item + " ";
            }
            return res;
        }
    }*/
    /*public class Deque<T>
{
    private readonly List<T> _list;

    public Deque()
    {
        _list = new List<T>();
    }

    public int Count => _list.Count;

    public void AddFront(T item)
    {
        _list.Insert(0, item);
    }

    public void AddBack(T item)
    {
        _list.Add(item);
    }

    public T RemoveFront()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Deque is empty");
        }

        T item = _list[0];
        _list.RemoveAt(0);

        return item;
    }

    public T RemoveBack()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Deque is empty");
        }

        int index = _list.Count - 1;
        T item = _list[index];
        _list.RemoveAt(index);

        return item;
    }

    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    public T GetFront()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Deque is empty");
        }

        return _list[0];
    }

    public T GetBack()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Deque is empty");
        }

        int index = _list.Count - 1;
        return _list[index];
    }
}*/
    public class MyDeque<T>
    {
        private T[] _array;
        private int _head;
        private int _tail;
        private int _size;

        public MyDeque(int capacity)
        {
            _array = new T[capacity];
            _head = _tail = _size = 0;
        }
        public MyDeque() : this(12)
        {

        }

        public int Count => _size;

        public void AddFirst(T item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Deque is full");
            }
            _head = (_head - 1 + _array.Length) % _array.Length;
            _array[_head] = item;
            _size++;
        }

        public void AddLast(T item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Deque is full");
            }

            _array[-_tail] = item;
            _tail = (_tail - 1) % _array.Length;
            _size++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            T item = _array[_head];
            _head = (_head + 1) % _array.Length;
            _size--;

            return item;
        }

        public T RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Deque is empty");
            }
            T item = _array[_tail];
            _tail = (_tail - 1 + _array.Length) % _array.Length;
            
            _size--;

            return item;
        }

        public bool IsEmpty => _size == 0;
        public bool IsFull => _size == _array.Length;
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _size; i++)
                str += _array[i] + " ";
            return str;
        }
    }
}
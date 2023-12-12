namespace Lab9
{
    public class MyList<T>
    {
        private T[] elements;
        private int index;
        public MyList(int size)
        {
            elements = new T[size];
            index = -1;
        }
        public MyList():this(12)
        {

        }
        public MyList(T[] elements, int index)
        {
            this.elements = elements;
            this.index = index;
        }

        public void Add(T item)
        {
            if (index == elements.Length)
            {
                Array.Resize(ref elements, elements.Length * 2+1);
            }
            elements[index] = item;
            index++;
        }
        public void AddRange(MyList<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Add(list.elements[i]);
            }
        }
        public T Removelast()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("Список пуст");
            }
            return elements[index--];
        }
        public void Remove(T item)
        {
            for (int i = 0; i <= index; i++)
            {
                if (elements[i].Equals(item))
                {
                    for (int j = i; j < index; j++)
                    {
                        elements[j] = elements[j + 1];
                    }
                    index--;
                    break;
                }
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= this.index)
            {
                for (int i = index; i < this.index; i++)
                {
                    elements[i] = elements[i + 1];
                }
                this.index--;
            }
        }
        public void MergeList(MyList<T> list)
        {
            AddRange(list);
        }
        public void MergeListNew(MyList<T> list)
        {
            MyList<T> el = new MyList<T>(elements, elements.Length);
            MyList<T> nl = new MyList<T>(elements.Length +list.Count);
            nl.AddRange(el);
            nl.AddRange(list);
        }
        public void CopyNFL()
        {

        }
        public void Clear()
        {
            index = -1;
            elements = new T[0];
        }
        public bool IsEmpty=> index == -1;
        public int Count => index + 1;
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Count; i++)
                res += elements[i] + " ";
            return res;
        }

    }
}
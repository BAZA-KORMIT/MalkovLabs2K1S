using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgosLab7
{
    public class PriorityQueue<T>
    {
        private List<Tuple<T, int>> queue;

        public PriorityQueue()
        {
            queue = new List<Tuple<T, int>>();
        }

        public int Count
        {
            get { return queue.Count; }
        }

        public void Enqueue(T item, int priority)
        {
            queue.Add(new Tuple<T, int>(item, priority));
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int highestPriority = int.MaxValue;
            int highestPriorityIndex = -1;

            for (int i = 0; i < queue.Count; i++)
            {
                if (queue[i].Item2 < highestPriority)
                {
                    highestPriority = queue[i].Item2;
                    highestPriorityIndex = i;
                }
            }

            T item = queue[highestPriorityIndex].Item1;
            queue.RemoveAt(highestPriorityIndex);
            return item;
        }

        public bool Contains(T item)
        {
            foreach (var tuple in queue)
            {
                if (tuple.Item1.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class prog
    {
        static void Main()
        {
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
            priorityQueue.Enqueue("Task 1", 2);
            priorityQueue.Enqueue("Task 2", 1);
            priorityQueue.Enqueue("Task 3", 3);

            while (priorityQueue.Count > 0)
            {
                string task = priorityQueue.Dequeue();
                Console.WriteLine($"Task: {task}");
            }
        }
    }
}


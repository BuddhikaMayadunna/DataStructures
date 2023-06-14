using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Queues<T>
    {
        public List<T> ItemsQueue { get; set; }
        public Queues()
        {
            ItemsQueue = new List<T>();
        }
        public void Enqueue(T element)
        {
            ItemsQueue?.Add(element);
        }

        public T? Dequeue()
        {
            if (ItemsQueue is not null)
            {
                var item = ItemsQueue.First();
                ItemsQueue.Remove(item);
                return item;
            }
            return default;
        }

        public T? Peek()
        {
            if (ItemsQueue is not null)
            {
                var item = ItemsQueue.First();
                return item;
            }
            return default;
        }

        public bool IsEmpty()
        {
            return ItemsQueue is null;
        }

        public void Display()
        {
            foreach (var item in ItemsQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}

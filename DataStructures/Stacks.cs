using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stacks<T>
    {

        public List<T> ItemsStack { get; set; }
        public Stacks()
        {
            ItemsStack = new List<T>();
        }
        public void Push(T element)
        {
            ItemsStack?.Add(element);
        }

        public T? Pop()
        {
            if (ItemsStack is not null)
            {
                var item = ItemsStack.Last();
                ItemsStack.Remove(item);
                return item;
            }
            return default;
        }

        public T? Top()
        {
            if (ItemsStack is not null)
                return ItemsStack.Last();
            return default;
        }

        public bool IsEmpty()
        {
            return ItemsStack is null;
        }

        public int Size()
        {
            return ItemsStack.Count;
        }

        public void Display()
        {
            foreach (var item in ItemsStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

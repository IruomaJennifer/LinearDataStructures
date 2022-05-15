using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructuresAssignment
{
    internal class CustomQueue<T>
    {
        public CustomLinkedList<T> MyQueue { get;private set; }

        public CustomQueue()
        {
            MyQueue = new CustomLinkedList<T>();
        }

        public void Enqueue(T item)
        {
            MyQueue.AddItem(item);
            var mine = new Queue<T>();
            
        }

        public T Dequeue()
        {
            var item = MyQueue.Head.Value;
            MyQueue.Remove(item);
            return item;
        }

        public void Clear()
        {
            MyQueue.Clear();
        }
        
        public bool Contains(T item)
        {
            if (!(MyQueue.Find(item) is null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

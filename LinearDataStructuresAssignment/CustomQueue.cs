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
            
        }

        public T Dequeue()
        {
            var item = MyQueue.Head.Value;
            MyQueue.Remove(item);
            return item;
        }

        public void Clear()
        {
            MyQueue.Head = null;
            MyQueue.Tail = null;
            MyQueue.Count = 0;
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

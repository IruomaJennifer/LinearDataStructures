using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructuresAssignment
{
    internal class CustomStack<T>
    {
        public CustomLinkedList<T> MyStack { get;private set; }

        public CustomStack()
        {
            MyStack=new CustomLinkedList<T>();
        }

        public void Push(T item)
        {
            MyStack.AddFirst(item);
        }

        public T Pop()
        {
            var item = MyStack.Head.Value;
            MyStack.Remove(item);
            return item;
        }

        public T Peek()
        {
            return MyStack.Head.Value;
        }
    }
}

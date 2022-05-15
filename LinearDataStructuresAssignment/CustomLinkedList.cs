using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructuresAssignment
{
    internal class CustomLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }
        public int Count { get; set; }

        public CustomLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void AddItem(T item)
        {
            if(Head == null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item,temp);
                temp.NextNode = newNode;
                Tail =newNode;
            }
            Count++;
        }
        public void AddFirst(T item)
        {
            if(Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Head;
                var newNode = new ListNode<T>(temp, item);
                temp.PreviousNode= newNode;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(T item)
        {
            AddItem(item);
           
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public ListNode<T>? Find(T item)
        {
            for (ListNode<T> current = Head; current != null; current=current.NextNode)
            {
                if(current.Value.Equals(item))
                {
                    return current;
                }
                
            }
            return null;
        }

        public void Remove(T item)
        {
            var itemToRemove = Find(item);
            if(itemToRemove != null)
            {
                Count--;
                if (itemToRemove.Equals(Head))
                {
                    var current = itemToRemove;
                    var next = current.NextNode;
                    Head = next;
                    current.NextNode = null;
                    
                }
                else if (itemToRemove.Equals(Tail))
                {
                    var current = itemToRemove;
                    var previous = current.PreviousNode;
                    Tail = previous;
                    current.PreviousNode = null;
                    
                }
                else
                {
                    var previous= itemToRemove.PreviousNode;
                    var next = itemToRemove.NextNode;
                    previous.NextNode = next;
                    next.PreviousNode = previous;
                    itemToRemove.PreviousNode = itemToRemove.NextNode = null;
                }
            }
            else
            {
                return;
            }
        }

    }
}

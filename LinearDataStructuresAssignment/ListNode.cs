using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructuresAssignment
{
    internal class ListNode<T>
    {
        public ListNode<T> PreviousNode { get; set; }
        public ListNode<T> NextNode { get; set; }
        public T Value { get; set; }

        public ListNode(T value,ListNode<T> previousNode):this(value)
        {
            PreviousNode = previousNode;
        }
        public ListNode(ListNode<T> nextNode,T value):this(value)
        {
            NextNode = nextNode;
        }
        public ListNode(T value)
        {
            Value = value;
            
        }
    }
}

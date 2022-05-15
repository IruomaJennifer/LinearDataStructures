using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructuresAssignment
{
    internal class CustomSet<T>
    {
        private CustomLinkedList<T> mySet = new CustomLinkedList<T> ();
        private int count;

        public int Count
        {
            get { return count; }
            set { count = mySet.Count; }
        }


        public bool Contains(T item)
        {
            if (mySet.Find(item) is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void Add(T item)
        {
            
            if (!Contains(item))
            {
                mySet.AddItem(item);
                
            }
            
        }

        
    }
}

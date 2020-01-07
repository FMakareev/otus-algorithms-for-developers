using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    class Stack<T>
    {

        private Node<T> head;


        public Stack()
        {
            head = null;
        }

        public void Push(T item)
        {
            head = new Node<T>(item, head);

        }

        public T Pop()
        {
            if (IsEmpty())
            {
                return default(T);
            }

            T item = head.Item;
            head = head.Next;
            return item;
        }


        public bool IsEmpty()
        {
            return head == null;
        }


    }
}

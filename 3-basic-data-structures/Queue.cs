using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    class Queue<T>
    {

        private Node<T> head, tail;

        public Queue()
        {
            head = null;
            tail = null;
        }

        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public Node<T> Tail
        {
            get
            {
                return tail;
            }
            set
            {
                tail = value;
            }
        }


        public void Enqueue(T item) {

            Node<T> node = new Node<T>(item);

            if (IsEmpty())
            {
                head = tail = node;
            } else
            {
                tail.Next = node;
                tail = node;
            }

        }
        public T Denqueue()
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

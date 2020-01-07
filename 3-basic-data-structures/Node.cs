using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{

    class Node<T>
    {
        private T item;
        private Node<T> next;

        public Node(T item, Node<T> next)
        {
            this.item = item;
            this.next = next;
        }

        public Node(T item)
        {
            this.item = item;
            this.next = null;
        }

        public T Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }


    }
}

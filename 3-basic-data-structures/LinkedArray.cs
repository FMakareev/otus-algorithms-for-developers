using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{




    class LinkedArray<T> : IArray<T>
    {

        private Queue<T> queue;
        private int size;


        public LinkedArray()
        {
            this.queue = new Queue<T>();
            size = 0;
        }

        public void Add(T item)
        {
            queue.Enqueue(item);
            size += 1;
        }

        public void Add(T item, int index)
        {
            if (index < size)
            {
                Node<T> node = new Node<T>(item);

                Node<T> curr = queue.Head;

                for (int j = 0; j < index - 1; j += 1)
                {
                    curr = curr.Next;
                }
                node.Next = curr.Next;
                curr.Next = node;

                size += 1;


            }

        }

        public T Get(int index)
        {
            if(index >= size)
            {
                return default(T);
            }

            Node<T> curr = queue.Head;

            for(int j = 0; j < index; j += 1)
            {
                curr = curr.Next;
            }

            return curr.Item;
        }

        public T Pop()
        {
            T removeItem = queue.Tail.Item;

            Node<T> curr = queue.Head;

            for (int j = 0; j < size - 2; j += 1)
            {
                curr = curr.Next;
            }
            queue.Tail = curr;
            curr.Next = null;

            size -= 1;
            return removeItem;
        }

        public T Remove(int index)
        {

            Node<T> removeNode = queue.Head;
            Node<T> prevNode = default(Node<T>);

            for (int j = 0; j < index; j += 1)
            {
                if(j == index - 1)
                {
                    prevNode = removeNode;
                }
                removeNode = removeNode.Next;
            }

            prevNode.Next = removeNode.Next;
            size -= 1;
            return removeNode.Item;
        }

        public T Shift()
        {
            size -= 1;
            return queue.Denqueue();
        }

        public int Size()
        {
            return size;
        }

        public void Swap(int source, int target)
        {
            throw new NotImplementedException();
        }

        public void Unshift(T item)
        {
            Node<T> node = new Node<T>(item);

            node.Next = queue.Head;

            queue.Head = node;
            size += 1;
        }
    }
}

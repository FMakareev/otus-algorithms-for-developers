using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    class PriorityQueue<T>
    {

        private int size;
        private SingleArray<Queue<T>> priorityList;


        public PriorityQueue()
        {
            size = 0;
            priorityList = new SingleArray<Queue<T>>();
            priorityList.Add(new Queue<T>(), 0);
            priorityList.Add(new Queue<T>(), 1);
            priorityList.Add(new Queue<T>(), 2);
        }


        public void Enqueue(T item, int priority)
        {
       
            if (priority > priorityList.Size() || priorityList.Get(priority) == null)
            {
                priorityList.Add(new Queue<T>(), priority);
            }

            priorityList.Get(priority).Enqueue(item);
            size += 1;

        }

        public T Dequeue()
        {
            T getItem = default(T);

            for (int i = 0; i < priorityList.Size(); i += 1)
            {
                if (priorityList.Get(i) != null)
                {
                    if (!priorityList.Get(i).IsEmpty())
                    {
                        getItem = priorityList.Get(i).Denqueue();
                        size -= 1;
                        break;
                    }
                }
            }

            return getItem;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }


    }
}

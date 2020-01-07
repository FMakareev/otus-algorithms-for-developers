using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
   public class SingleArray<T> : IArray<T>
    {

        private T[] array;

        public SingleArray()
        {
            array = new T[0];
        }

        public SingleArray(int size)
        {
            array = new T[size];
        }

        public int Size()
        {
            return array.Length;
        }

        public void Add(T item)
        {
            resize();
            array[Size() - 1] = item;
        }

        public void Add(T item, int index)
        {
            if (index > Size() - 1)
            {
                int diff = index - Size();
       
                T[] newArray = new T[Size() + diff + 1];

                Array.Copy(array, 0, newArray, 0, Size());

                array = newArray;
            }
            array[index] = item;
        }

        /// <summary>
        /// delete from the array end
        /// </summary>
        public T Pop()
        {
            T removeItem = default(T);
            if (Size() > 0)
            {
                removeItem = array[Size() - 1];
                resize(Size() - 1);
            }
            return removeItem;
        }

        /// <summary>
        /// remove item from array start
        /// </summary>
        /// <returns>
        /// deleted item
        /// </returns>
        public T Shift()
        {
            T removeItem = default(T);
            if (Size() > 0)
            {
                T[] newArray = new T[Size() - 1];
                removeItem = array[0];

                Array.Copy(array, 1, newArray, 0, Size() - 1);

                array = newArray;
            }
            return removeItem;
        }

        /// <summary>
        /// add item in array start
        /// </summary>
        /// <param name="item"></param>
        public void Unshift(T item)
        {
            T[] newArray = new T[Size() + 1];
            Array.Copy(array, 0, newArray, 1, Size());
            array = newArray;
            array[0] = item;
        }

        public T Get(int index)
        {
            if(index > array.Length - 1)
            {
                return default(T);
            }
            return array[index];
        }

        public T Remove(int index)
        {
            T removeItem = default(T);
            if (index < array.Length)
            {
                T[] newArray = new T[Size() - 1];
                removeItem = array[index];

                Array.Copy(array, 0, newArray, 0, index);
                Array.Copy(array, index + 1, newArray, index, newArray.Length - index);

                array = newArray;
            }
            return removeItem;
        }

        public void Swap(int source, int target)
        {
            T temp = array[source];
            array[source] = array[target]; 
            array[target] = temp;
        }


        private void resize()
        {
            T[] newArray = new T[Size() + 1];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }

        private void resize(int size)
        {
            T[] newArray = new T[size];
            Array.Copy(array, 0, newArray, 0, size);
            array = newArray;
        }
    }
}

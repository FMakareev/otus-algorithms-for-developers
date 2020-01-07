using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
   public class FactorArray<T>: IArray<T>
    {

        private T[] array;
        private int vector;
        private int size = 0;

        public int Size()
        {
            return size;
        }

        public FactorArray(int vector)
        {
            array = new T[10];
            this.vector = vector;
        }

        public void Add(T item)
        {
            if (Size() == array.Length)
            {
                resize();
            }
            array[size] = item;
            size += 1;

        }

        public void Add(T item, int index)
        {
            if (index > array.Length)
            {
                resize(index);
            }
            array[index] = item;
            size = index;
        }

        public T Get(int index)
        {
            return array[index];
        }

        public T Pop()
        {
            T removeItem = default(T);
            if (Size() > 0)
            {
                removeItem = array[Size() - 1];

                T[] newArray = new T[size];
                Array.Copy(array, 0, newArray, 0, Size() - 1);
                array = newArray;

                size -= 1;
            }
            return removeItem;
        }

        public T Shift()
        {
            T removeItem = default(T);
            if (Size() > 0)
            {
                T[] newArray = new T[Size() - 1];
                removeItem = array[0];

                Array.Copy(array, 1, newArray, 0, Size() - 1);

                array = newArray;
                size -= 1;
            }
            return removeItem;
        }

        public void Unshift(T item)
        {
            T[] newArray = new T[Size() + 1];
            Array.Copy(array, 0, newArray, 1, Size());
            array = newArray;
            array[0] = item;
            size += 1;
        }

        public void Swap(int source, int target)
        {
            T temp = array[source];
            array[source] = array[target];
            array[target] = temp;
        }

        public T Remove(int index)
        {
            T removeItem = default(T);
            if (index < Size())
            {
                T[] newArray = new T[Size() - 1];
                removeItem = array[index];

                Array.Copy(array, 0, newArray, 0, index);
                Array.Copy(array, index + 1, newArray, index, newArray.Length - index);
                size -= 1;
                array = newArray;
            }
            return removeItem;
        }

        private void resize()
        {
            T[] newArray = new T[Size() * vector / 100];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }

        private void resize(int size)
        {
            T[] newArray = new T[size];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }
    }
}

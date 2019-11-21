using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    class VectorArray<T> : IArray<T>
    {

        private T[] array;
        private int vector
        {
            get { return Size() * 2 / 3 + 1; }
        }
        private int size = 1;

        public int Size()
        {
            return size;
        }

        public VectorArray()
        {
            array = new T[size];
        }
        public VectorArray(int size)
        {
            array = new T[size];
            this.size = size;
        }

        public void Add(T item)
        {
            if (Size() == array.Length)
            {
                resize();
            }
            array[Size() - 1] = item;
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
        public void Swap(int source, int target)
        {
            T temp = array[source];
            array[source] = array[target];
            array[target] = temp;
        }

        public T Pop()
        {
            throw new NotImplementedException();

        }
        public T Shift()
        {
            throw new NotImplementedException();
        }

        public void Unshift(T item)
        {
            throw new NotImplementedException();
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
        
        private void resize()
        {
            T[] newArray = new T[Size() + vector];
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

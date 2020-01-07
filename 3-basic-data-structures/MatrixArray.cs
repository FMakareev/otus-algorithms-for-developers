using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    public class MatrixArray<T> : IArray<T>
    {

        private int size;

        private int vector;

        private SingleArray<VectorArray<T>> array;


        public MatrixArray(int vector)
        {
            this.vector = vector;
            array = new SingleArray<VectorArray<T>>();
            size = 0;
        }


        public int Size()
        {
            return size;
        }


        public void Add(T item)
        {
            if (size == array.Size() * vector)
            {
                array.Add(new VectorArray<T>(vector));
            }

            int index = Size();

            if (array.Get(index / vector) != null)
            {
                array.Get(index / vector).Add(item);
                size += 1;
            }
            else
            {
                array.Add(new VectorArray<T>(vector), index / vector);
                array.Get(index / vector).Add(item);
            }
        }

        public void Add(T item, int index)
        {
            if (index > Size())
            {

                int rowIndex = index / vector;

                array.Add(new VectorArray<T>(vector), rowIndex);

                array.Get(rowIndex).Add(item, index % vector);

                size = index;
            }
            else
            {
                if (array.Get(index / vector) != null)
                {
                    array.Get(index / vector).Add(item, index % vector);
                }
                else
                {
                    array.Add(new VectorArray<T>(vector), index / vector);
                    array.Get(index / vector).Add(item, index % vector);
                }
            }

        }

        public T Get(int index)
        {
            int row = index / vector;
            int item = index % vector;
            if(array.Get(row) != null)
            {
                return array.Get(row).Get(item);
            }
            return default(T);
        }

        public T Pop()
        {
            T removeItem = default(T);



            return removeItem;
        }

        public T Remove(int index)
        {
            if (index > Size())
            {
                return default(T);
            }
            T removeItem = Get(index);
            int row = index / vector;
            int item = index % vector;
            if (array.Get(row) != null)
            {
                return array.Get(row).Remove(item);
            }
            return default(T);
        }

        public T Shift()
        {
            return Remove(0);
        }

        public void Swap(int source, int target)
        {
            throw new NotImplementedException();
        }

        public void Unshift(T item)
        {
            Add(item, 0);
        }
    }
}

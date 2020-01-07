using System;
using System.Collections.Generic;
using System.Text;

namespace _7_heap_sort
{
    class BinaryHeap : IBinaryHeap
    {
        public int[] elements;
        public int size = 0;

        public BinaryHeap(int _size)
        {
            elements = new int[_size];
        }

        public BinaryHeap(int[] arr)
        {
            elements = arr;
            size = elements.Length;
        }

        public int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        public int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        public int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;


        public int GetLeftChild(int elementIndex) => elements[GetLeftChildIndex(elementIndex)];
        public int GetRightChild(int elementIndex) => elements[GetRightChildIndex(elementIndex)];
        public int GetParent(int elementIndex) => elements[GetParentIndex(elementIndex)];


        public bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < size;
        public bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < size;
        public bool IsRoot(int elementIndex) => elementIndex == 0;

        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Peek()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return elements[0];
        }
    
        public int Pop()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }


            int result = elements[0];

            int[] newArray = new int[elements.Length - 1];
            Array.Copy(elements, 1, newArray, 0, newArray.Length);
            elements = newArray;
            size -= 1;

            ReCalculateDown();

            return result;
        }

        public void Add(int element)
        {

            if (size == elements.Length)
            {
                elements = resize(elements, elements.Length + 1);
            }

            elements[size] = element;
            size += 1;

            ReCalculateUp();
        }

        private int[] resize(int[] arr, int size) {
            int[] newArray = new int[size];
            Array.Copy(arr, 0, newArray, 0, arr.Length);
            return newArray;
        }

        public virtual void ReCalculateDown()
        {
            throw new NotImplementedException();
        }

        public virtual void ReCalculateUp()
        {
            throw new NotImplementedException();
        }
    }
}

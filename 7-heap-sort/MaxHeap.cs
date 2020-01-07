using System;
using System.Collections.Generic;
using System.Text;

namespace _7_heap_sort
{
    class MaxHeap : BinaryHeap
    {       
        public MaxHeap(int size): base(size)
        {
        }

        public MaxHeap(int[] arr) : base(arr)
        {
        }
        public override void ReCalculateDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int biggerIndex = GetLeftChildIndex(index);

                if(HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if(elements[biggerIndex] < elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }

        }

        public override void ReCalculateUp()
        {
            int index = size - 1;

            while (!IsRoot(index) && elements[index] > GetParent(index)) {

                int parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }




    }
}

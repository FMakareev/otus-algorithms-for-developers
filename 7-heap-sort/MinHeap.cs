using System;
using System.Collections.Generic;
using System.Text;

namespace _7_heap_sort
{
    class MinHeap : BinaryHeap
    {

        public MinHeap(int size) : base(size)
        {
        }

        public MinHeap(int[] arr) : base(arr)
        {
        }

        public override void ReCalculateDown() {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (elements[smallerIndex] >= elements[index])
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;

            }

        }
        public override void ReCalculateUp() {

            var index = size - 1;
            while (!IsRoot(index) && elements[index] < GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }

        }

    }
}

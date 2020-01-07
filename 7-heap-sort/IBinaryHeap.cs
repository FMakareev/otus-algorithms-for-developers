using System;
using System.Collections.Generic;
using System.Text;

namespace _7_heap_sort
{
    interface IBinaryHeap
    {

        int GetLeftChildIndex(int elementIndex);
        int GetRightChildIndex(int elementIndex);
        int GetParentIndex(int elementIndex);

        int GetLeftChild(int elementIndex);
        int GetRightChild(int elementIndex);
        int GetParent(int elementIndex);
        bool HasLeftChild(int elementIndex);
        bool HasRightChild(int elementIndex);
        bool IsRoot(int elementIndex);
        void Swap(int firstIndex, int secondIndex);
        bool IsEmpty();
        int Peek();
        int Pop();
        void Add(int element);
        void ReCalculateDown();
        void ReCalculateUp();
    }
}

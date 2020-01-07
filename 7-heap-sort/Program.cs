using System;
using Utilites;

namespace _7_heap_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7-heap-sort!");

            int[] arr = { 7, 4, 3, 8, 3, 5, 6, 1, 9, 0 };

            MinHeap heap = new MinHeap(arr.Length);

            for(int i = 0; i< arr.Length; i += 1)
            {
                heap.Add(arr[i]);
            }

            Utilites.Utilites.printArray(heap.elements);

            HeapSort hSort = new HeapSort();

            hSort.MaxHeapSort(heap.elements);



        }


        static void HeapSort(int[] arr)
        {
            // переперамидить.
            // move [root] element to [place]
            void Down(int size, int root)
            {
                int left = root * 2 + 1; // левый лепесток рута
                int right = root * 2 + 2; // правый лепесток рута

                int X = root; // предполагаем что максимальный элементв корне

                if (left < size && arr[left] > arr[X])
                {
                    X = left;
                }
                if (right < size && arr[right] > arr[X])
                {
                    X = right;
                }
                if (X == root)
                {
                    return;
                }
                Swap(root, X);
                Down(size, X);
            }

            void Swap(int x, int y)
            {
                int t = arr[x];
                arr[x] = arr[y];
                arr[y] = t;
            }

            for (int node = arr.Length / 2 - 1; node >= 0; node -= 1)
            {
                Down(arr.Length, node);
            }


            for (int size = arr.Length - 1; size >= 0; size -= 1)
            {
                Swap(0, size);
                Down(size, 0);
            }


        }
    }
}

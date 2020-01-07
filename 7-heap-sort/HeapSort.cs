using System;
using System.Collections.Generic;
using System.Text;

namespace _7_heap_sort
{
    class HeapSort
    {

        /// Обмен элементов местами
       private int[] swap(int[] arr, int first, int last)
        {
            int temp = arr[first];
            arr[first] = arr[last];
            arr[last] = temp;
            return arr;
        }

        public void MaxHeapSort(int[] arr)
        {
            /// <summary>
            /// метод сравнивает содержимое левого и правого листов с родителем 
            /// и если один из них больше родителя меняет его с ним местами
            /// </summary>
            /// <param name="size">Размер массива</param>
            /// <param name="root">index родителя</param>
            void SiftDown(int size, int root)
            {

                int Left = root * 2 + 1; // вычисляем индекс левого листа
                int Right = root * 2 + 2; // вычисляем индекс правого листа

                int Max = root; // индекс предпалогаемого максимального элемента

                // Если индекс не выходит за рамки массива и элемент по этому индексу больше чем элемент родитель
                if (Left < size && arr[Left] > arr[Max])
                {
                    Max = Left;
                }
                // Если индекс не выходит за рамки массива и элемент по этому индексу больше чем элемент родитель
                if (Right < size && arr[Right] > arr[Max])
                {
                    Max = Right;
                }

                // Если максимальный элемент это рут то выходим из цикла
                if (Max == root)
                {
                    return;
                }
                // Меняю максимальный элемент (он же лист рута) и рут местами
                swap(arr, Max, root);

                SiftDown(size, Max);
            }


            // int node = arr.Length / 2 - 1; - получаю индекс родителя последнего элемента в куче
            for (int node = arr.Length / 2 - 1; node >= 0; node -= 1)
            {
                SiftDown(arr.Length, node);
            }

            for (int arrSize = arr.Length - 1; arrSize >= 0; arrSize -= 1)
            {
                swap(arr, 0, arrSize);
                SiftDown(arrSize, 0);
            }
        }

        public void MinHeapSort(int[] arr) {




        }


    }
}

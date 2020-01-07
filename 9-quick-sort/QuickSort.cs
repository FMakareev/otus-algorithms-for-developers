using System;
using System.Collections.Generic;
using System.Text;

namespace _8_quick_sort
{
    class QuickSort
    {
        public void Sort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            // центер массива
            int center = Partiotion(array, low, high);
            // сортируем массив от начала до середины
            Sort(array, low, center - 1);
            // сортируем массив от середины до конца
            Sort(array, center + 1, high);
        }

        public int Partiotion(int[] array, int low, int high)
        {
            int i = -1;
            int pivot = array[high];
            for (int j = 0; j < array.Length; j += 1)
            {
                if (array[j] <= pivot)
                {
                    i += 1;
                    int x = array[i];
                    array[i] = array[j];
                    array[j] = x;
                }
            }


            return i;
        }
    }
}

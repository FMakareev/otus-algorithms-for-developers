using System;
using System.Collections.Generic;
using System.Text;

namespace _6_sorting
{
    class InsertSort
    {

        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="arr"></param>
        public InsertSort(int[] arr)
        {

            void PutMaxToRoot(int size, int root)
            {

                for (int j = root + 1; j < size; j += 1)
                {
                    if (arr[j] > arr[root])
                    {
                        Swap(j, root);
                    }
                }

            }

            void Swap(int x, int y)
            {
                int t = arr[x];
                arr[x] = arr[y];
                arr[y] = t;
            }

            PutMaxToRoot(arr.Length, 0);

            for (int size = arr.Length - 1; size >= 0; size -= 1)
            {
                Swap(0, size);
                PutMaxToRoot(size, 0);
            }


        }
    }
}

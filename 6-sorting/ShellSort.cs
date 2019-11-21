using System;
using System.Collections.Generic;
using System.Text;
using _3_basic_data_structures;

namespace _6_sorting
{
    class ShellSort
    {


        public ShellSort(in IArray<int> arr)
        {
            int length = arr.Size();
            // шаг между сравниваемыми значениями
            int d = length / 2;

            while (d >= 1)
            {

                for (int i = d; i < length; i += 1)
                {
                    int j = i;

                    while ((j >= d) && (arr.Get(j - d) > arr.Get(j)))
                    {
                        arr.Swap(j, j - d);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
    }
}

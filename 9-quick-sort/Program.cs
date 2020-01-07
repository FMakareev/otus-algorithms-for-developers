using System;
using Utilites;
namespace _8_quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 12, 24, 50, 14, 30, 70, 28, 46, 19, 35 };





            int[] arr1 = { 1, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8 };

            //int[] arr3 = Program.Merge(arr1, arr2);

            //Utilites.Utilites.printArray(arr3);
        }

        void MergeSort(int[] arr, int left, int right)
        {

            if(left >= right)
            {
                return;
            }
            int center = left + (right - left) / 2;

            MergeSort(arr, left, center);
            MergeSort(arr, center + 1, right);
            arr = Merge(arr, left, center, right);
        }

        static int[] Merge(int[] arr, int left, int center, int right)
        {

            int[] result = new int[right - left + 1];

            int a = left;
            int b = center + 1;
            int r = 0;

            while (a <= center && b <= right)
            {
                if (arr[a] < arr[b])
                {
                    result[r++] = arr[a++];
                }
                else
                {
                    result[r++] = arr[b++];
                }
            }

            while (a <= center)
            {
                result[r++] = arr[a++];
            }

            while (b <= right) {
                    result[r++] = arr[b++];
            }


            for(int j = left; j <= right; j++)
            {

            }


            return result;
        }


    }
}

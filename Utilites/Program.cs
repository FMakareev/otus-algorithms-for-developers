using System;

namespace Utilites
{
   public class Utilites
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i += 1)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}

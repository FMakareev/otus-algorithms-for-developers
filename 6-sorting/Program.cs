using System;
using _3_basic_data_structures;


namespace _6_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IArray<int> singleArray = new SingleArray<int>();
            var rand = new Random();

            for (int i = 0; i < 5; i += 1)
            {
                int index = rand.Next(1, i * 2 + 1);
                singleArray.Add(index);
            }

            Program.printArray(singleArray);
            new ShellSort(singleArray);
            Program.printArray(singleArray);
        }

        static void printArray(IArray<int> arr)
        {
            int n = arr.Size();
            for (int i = 0; i < n; i += 1)
            { 
                Console.Write(arr.Get(i) + " ");
            }
            Console.WriteLine();
        }

    }
}

using System;
using System.Diagnostics;
using ConsoleTables;

namespace _3_basic_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.StackTest();
            //Program.QueueTest();
            //Program.LinkedArrayTest();
            Program.PriorityQueueTest();



            Program.createResultTable();

        }

        static void LinkedArrayTest()
        {
            LinkedArray<string> arr = new LinkedArray<string>();
            arr.Add("Java");
            arr.Add("C++");
            arr.Add("TypeScript");
            arr.Add("PHP");
            arr.Add("Javascript");

            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }
            Console.WriteLine("=====");

            arr.Add("Lisp", 2);

            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }

            Console.WriteLine("=====");
            Console.WriteLine(arr.Pop());
            Console.WriteLine(arr.Size());
            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }
            Console.WriteLine("=====");
            Console.WriteLine(arr.Shift());
            Console.WriteLine(arr.Size());

            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }
            Console.WriteLine("=====");

            arr.Unshift("GO");

            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }
            Console.WriteLine("=====");
            arr.Remove(2);
            for (int i = 0; i < arr.Size(); i += 1)
            {
                Console.WriteLine(arr.Get(i));
            }
            Console.WriteLine("=====");
        }
            
        static void QueueTest()
        {
            Queue<string> stack = new Queue<string>();
            stack.Enqueue("Java");
            stack.Enqueue("C++");
            stack.Enqueue("TypeScript");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Denqueue());
            }
        }

        static void StackTest()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Java");
            stack.Push("C++");
            stack.Push("TypeScript");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }

        static void PriorityQueueTest()
        {
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();

            priorityQueue.Enqueue("a", 0);
            priorityQueue.Enqueue("b", 0);
            priorityQueue.Enqueue("c", 1);
            priorityQueue.Enqueue("d", 1);
            priorityQueue.Enqueue("e", 4);
            
            while (!priorityQueue.IsEmpty())
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }


        }

        static void createResultTable()
        {
            IArray<string> singleArray = new SingleArray<string>();
            IArray<string> vectorArray = new VectorArray<string>();
            IArray<string> factorArray = new FactorArray<string>(1000);
            IArray<string> matrixArray = new MatrixArray<string>(1000);


            ConsoleTable timeTable = new ConsoleTable("Data structure",
                "Added 100000 elements",
                "Added in start",
                "Random added",
                "Added in end",
                "Read start",
                "Read random",
                "Read end",
                "Delete start",
                "Delete random",
                "Delete end"
                );

            Program.addValues("Single Array", singleArray, 100000, in timeTable);
            Program.addValues("Vector Array", vectorArray, 100000, in timeTable);
            Program.addValues("Factor Array", factorArray, 100000, in timeTable);
            Program.addValues("Matrix Array", matrixArray, 100000, in timeTable);



        }


        static double addValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Unshift("start");
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double addValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size());
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Add("rand", index);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double addValueInEnd(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Add("end");
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }


        static double readValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(0);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double readValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size() - 1);
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(index);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double readValueInEnd(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(array.Size() - 1);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds;
        }


        static double deleteValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Remove(0);
            stopWatch.Stop();

            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double deleteValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size());

            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Remove(index);
            stopWatch.Stop();

            return stopWatch.Elapsed.TotalMilliseconds;
        }
        static double deleteValueInEnd(IArray<string> array)
        {

            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Pop();
            stopWatch.Stop();

            return stopWatch.Elapsed.TotalMilliseconds;
        }


        static void addValues(string arrayName, IArray<string> array, int count, in ConsoleTable table)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i += 1)
            {
                array.Add(i.ToString());
            }
            stopWatch.Stop();

            double col0 = stopWatch.Elapsed.TotalMilliseconds;

            double col1 = Program.addValueInStart(array);
            double col2 = Program.addValueInPositionRandom(array);
            double col3 = Program.addValueInEnd(array);

            double col4 = Program.readValueInStart(array);
            double col5 = Program.readValueInPositionRandom(array);
            double col6 = Program.readValueInEnd(array);

            double col7 = Program.deleteValueInStart(array);
            double col8 = Program.deleteValueInPositionRandom(array);
            double col9 = Program.deleteValueInEnd(array);



            table.AddRow(arrayName,
               col0, // "Added 100000 elements"
               col1, //"Added in start"
               col2, //"Random added"
               col3, // "Added in end"

               col4, // "Read start"
               col5, // "Read random"
               col6, // "Read end"

               col7, // "Delete start"
               col8, // "Delete random"
               col9  // "Delete end"
            );

            table.Write();

        }

    }
}

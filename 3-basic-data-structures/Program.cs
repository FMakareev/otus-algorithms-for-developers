using System;
using System.Diagnostics;
using ConsoleTables;

namespace _3_basic_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            IArray<string> singleArray = new SingleArray<string>();

            Program.createResultTable();

            //for (int i = 0; i < 10; i += 1)
            //{
            //    singleArray.Add(i.ToString());
            //    Console.WriteLine(singleArray.Get(i));
            //}

            //singleArray.Pop();
            //Console.WriteLine("Pop:");

            //for (int i = 0; i < singleArray.Size(); i += 1)
            //{
            //    Console.WriteLine(singleArray.Get(i));
            //}

            //singleArray.Shift();
            //Console.WriteLine("Shift:");

            //for (int i = 0; i < singleArray.Size(); i += 1)
            //{
            //    Console.WriteLine(singleArray.Get(i));
            //}

            //singleArray.Unshift("asdasda");
            //Console.WriteLine("Unshift:");

            //for (int i = 0; i < singleArray.Size(); i += 1)
            //{
            //    Console.WriteLine(singleArray.Get(i));
            //}
        }


        static void createResultTable()
        {
            IArray<string> singleArray = new SingleArray<string>();
            IArray<string> vectorArray = new VectorArray<string>(10);
            IArray<string> factorArray = new FactorArray<string>(1000);


            ConsoleTable timeTable = new ConsoleTable("Data structure",
                "Added 100000 elements",
                "Added in start", "Random added", "Added in end",
                "Read start", "Read random", "Read end",
                "Delete start", "Delete random", "Delete end"
                );
            Program.addValues(singleArray, 1000000, in timeTable);





            //addValuesTable
            //    .AddRow("Added", 1000, Program.addValues(singleArray, 1000), Program.addValues(vectorArray, 1000), Program.addValues(factorArray, 1000))
            //    .AddRow("Added", 10000, Program.addValues(singleArray, 10000), Program.addValues(vectorArray, 10000), Program.addValues(factorArray, 10000))
            //    .AddRow("Added", 100000, Program.addValues(singleArray, 100000), Program.addValues(vectorArray, 100000), Program.addValues(factorArray, 100000));

            //addValuesTable
            //    .AddRow("Delete from the middle", 100000, Program.deleteFromTheMiddle(singleArray, 100000), Program.deleteFromTheMiddle(vectorArray, 100000), Program.deleteFromTheMiddle(factorArray, 100000));

            //addValuesTable.Write();

            //Console.WriteLine();

        }


        static long addValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Unshift("start");
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long addValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size());
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Add("rand", index);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long addValueInEnd(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            array.Add("end");
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }


        static long readValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(0);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long readValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size() - 1);
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(index);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long readValueInEnd(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(array.Size() - 1);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }


        static long deleteValueInStart(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(0);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long deleteValueInPositionRandom(IArray<string> array)
        {
            var rand = new Random();
            int index = rand.Next(0, array.Size());
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Get(index);
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }
        static long deleteValueInEnd(IArray<string> array)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            string item = array.Pop();
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }


        static string addValues(IArray<string> array, int count, in ConsoleTable table)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i += 1)
            {
                array.Add(i.ToString());
            }
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);


            long col1 = Program.addValueInStart(array);
            long col2 = Program.addValueInPositionRandom(array);
            long col3 = Program.addValueInEnd(array);

            long col4 = Program.readValueInStart(array);
            long col5 = Program.readValueInPositionRandom(array);
            long col6 = Program.readValueInEnd(array);

            long col7 = Program.deleteValueInStart(array);
            long col8 = Program.deleteValueInPositionRandom(array);
            long col9 = Program.deleteValueInEnd(array);



            table.AddRow("SingleArray",
               stopWatch.Elapsed, // "Added 100000 elements"
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

            return elapsedTime;
        }

    }
}

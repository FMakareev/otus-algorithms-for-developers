using System;
using System.Collections.Generic;
using System.Text;
using _3_basic_data_structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3_basic_data_structures_test
{
    class ArrayTestPack
    {
        public static void addValues(IArray<string> array, int count, string addedElement = "")
        {
            for (int i = 0; i < count; i += 1)
            {
                if (addedElement == "")
                {
                    array.Add(i.ToString());
                }
                else
                {
                    array.Add(addedElement);
                }
            }
        }

        public static void FillArrayTest(IArray<string> array)
        {
            int length = 100;
            addValues(array, length);

            Assert.AreEqual(array.Size(), length, 0, "Массив не соответствующей длинны");
        }

        public static void AddToEndTest(IArray<string> array)
        {
            int length = 100;
            string addedElement = "1000";
            addValues(array, length);

            array.Add(addedElement);

            Assert.AreEqual(addedElement, array.Get(array.Size() - 1), "Последний элемент не равен добавленному");

        }

        public static void AddToRandomPositionTest(IArray<string> array)
        {
            int length = 100;
            string addedElement = "1000";

            addValues(array, length);

            var rand = new Random();
            int index = rand.Next(0, array.Size());

            array.Add(addedElement, index);

            Assert.AreEqual(addedElement, array.Get(index), "Не совпадают");

        }

        public static void AddWithIndexOverSizeArray(IArray<string> array)
        {

            int length = 10;
            string addedElement = "1000";
            int indexAddedElement = 20;

            addValues(array, length);

            array.Add(addedElement, indexAddedElement);


            Assert.AreEqual(array.Size(), indexAddedElement + 1, "Длинна массива меньше чем индекс добавленного элемента");

            Assert.AreEqual(addedElement, array.Get(indexAddedElement), "Не совпадают");


        }


        public static void RemoveLasteElement(IArray<string> array)
        {

            int length = 100;

            addValues(array, length, "element");

            array.Add("RemovedElement");

            string removeElement = array.Pop();

            Assert.AreNotEqual(removeElement, array.Get(array.Size() - 1), "Последний элемент совпадает с удаленным");

        }
        public static void RemoveFirstElement(IArray<string> array)
        {
            int length = 100;

            addValues(array, length, "element");

            array.Add("RemovedElement", 0);

            string removeElement = array.Pop();

            Assert.AreNotEqual(removeElement, array.Get(0), "Элемент совпадает с удаленным");

        }
        public static void RemoveRandomPositionElement(IArray<string> array)
        {
            int length = 100;
            var rand = new Random();
            int index = rand.Next(0, array.Size());

            addValues(array, length, "element");

            array.Add("RemovedElement", index);

            string removeElement = array.Remove(index);

            Assert.AreNotEqual(removeElement, array.Get(index), "Элемент совпадает с удаленным");
        }
    }
}

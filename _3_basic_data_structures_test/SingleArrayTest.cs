using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_basic_data_structures;
using System;


namespace _3_basic_data_structures_test
{
    [TestClass]
    public class SingleArrayTest
    {

        [TestMethod]
        public void FillArrayTest()
        {
            IArray<string> singleArray = new SingleArray<string>();
            int length = 100;
            ArrayTestPack.addValues(singleArray, length);
            Assert.AreEqual(singleArray.Size(), length, 0, "Массив не соответствующей длинны");
        }


        [TestMethod]
        public void AddToEndTest()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.AddToEndTest(singleArray);
        }

        [TestMethod]
        public void AddToRandomPositionTest()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.AddToRandomPositionTest(singleArray);
        }
        [TestMethod]
        public void AddWithIndexOverSizeArray()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.AddWithIndexOverSizeArray(singleArray);
        }
               
        [TestMethod]
        public void RemoveLasteElement()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.RemoveLasteElement(singleArray);            
        }
        [TestMethod]
        public void RemoveFirstElement()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.RemoveFirstElement(singleArray);
        }
        [TestMethod]
        public void RemoveRandomPositionElement()
        {
            IArray<string> singleArray = new SingleArray<string>();
            ArrayTestPack.RemoveRandomPositionElement(singleArray);
        }
        
    }
    

}

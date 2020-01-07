using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_basic_data_structures;
using System;

namespace _3_basic_data_structures_test
{
    [TestClass]
    public class FactorArrayTest
    {
        [TestMethod]
        public void FillArrayTest()
        {
            int length = 1000;
            IArray<string> vectorArray = new FactorArray<string>(length);
            ArrayTestPack.addValues(vectorArray, length);
            Assert.IsTrue(vectorArray.Size() == length, "Массив не соответствующей длинны");
        }
    }
}

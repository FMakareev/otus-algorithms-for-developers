using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_basic_data_structures;
using System;

namespace _3_basic_data_structures_test
{
    [TestClass]
    public class VectorArrayTest
    {

        [TestMethod]
        public void FillArrayTest()
        {
            IArray<string> vectorArray = new VectorArray<string>();
            int length = 100;
            ArrayTestPack.addValues(vectorArray, length);
            Assert.IsTrue(vectorArray.Size() > length, "Массив не соответствующей длинны");
        }

    }
}

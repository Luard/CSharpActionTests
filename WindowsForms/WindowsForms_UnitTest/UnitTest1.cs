using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsForms;

namespace WindowsForms_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(123, 456, 579)]
        [DataRow(1, 1, 2)]
        public void TestMethod1(int value1, int value2, int result)
        {
            Assert.AreEqual(Operaciones.Suma(value1, value2), result);
        }
    }
}

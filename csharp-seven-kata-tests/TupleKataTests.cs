using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class TupleKataTests
    {
        [TestMethod]
        public void Validate_Multi_Returns_Method()
        {
            var tupleKata = new TupleKata();

            Assert.AreEqual(4, tupleKata.GetArrLengths().StringArr);
            Assert.AreEqual(3, tupleKata.GetArrLengths().IntArr);
            
        }
    }
}

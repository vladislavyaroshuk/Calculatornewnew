using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(4,6)]
        public void TestSum(int a, int b)
        {
            var expResult = a + b;

            var result = Calculator.Sum(a, b);

            Assert.AreEqual(result, expResult);
        }

        [TestMethod]
        [DataRow(7, 5)]
        public void TestMinus(int a, int b)
        {
            var expResult = a + b;

            var result = Calculator.Sum(a, b);

            Assert.AreEqual(result, expResult);
        }

        [TestMethod]
        [DataRow(6, 2)]
        public void TestMultiple(int a, int b)
        {
            var expResult = a + b;

            var result = Calculator.Sum(a, b);

            Assert.AreEqual(result, expResult);
        }

        [TestMethod]
        [DataRow(10, 2)]
        public void TestDivide(int a, int b)
        {
            var expResult = a + b;

            var result = Calculator.Sum(a, b);

            Assert.AreEqual(result, expResult);
        }
    }
}

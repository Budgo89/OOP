using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplexTest
{
    [TestClass]
    public class ComplexTestEquality
    {
        [TestMethod]
        public void TestMethod()
        {
            Complex a = new Complex(1, 3);
            Complex b = new Complex(1, 3);
            bool expected = true;
            var actual = a == b;
            Assert.AreEqual(expected, actual);
        }
    }
}


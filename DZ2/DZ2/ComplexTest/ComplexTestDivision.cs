using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplexTest
{
    [TestClass]
    public class ComplexTestDivision
    {
        [TestMethod]
        public void TestMethod()
        {
            Complex a = new Complex(1, 3);
            Complex b = new Complex(2, 4);
            Complex c = new Complex(0.7, 0.1);
            bool expected = true;

            var z = a / b;
            var actual = z == c;

            Assert.AreEqual(expected, actual);
        }
    }
}


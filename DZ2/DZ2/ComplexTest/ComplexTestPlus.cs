using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplexTest
{
    [TestClass]
    public class ComplexTestPlus
    {
        [TestMethod]
        public void TestMethod1()
        {
            Complex a = new Complex(1, 3);
            Complex b = new Complex(2, 4);
            Complex c = new Complex(3, 7);
            bool expected = true;

            var z = a + b;
            var actual = z == c;

            Assert.AreEqual(expected, actual);

        }
    }
}

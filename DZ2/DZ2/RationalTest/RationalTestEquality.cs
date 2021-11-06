using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RationalTest
{
    [TestClass]
    public class RationalTestEquality
    {
        [TestMethod]
        public void TestMethod()
        {
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 2);
            bool expected = true;

            var actual = a==b;

            Assert.AreEqual(expected, actual);
        }
    }
}

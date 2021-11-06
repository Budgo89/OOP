using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RationalTest
{
    [TestClass]
    public class RationalTestPlus
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rational a = new Rational(1, 4);
            Rational b = new Rational(1, 2);
            Rational expected = new Rational(3, 4);

            var actual = a + b;

            Assert.AreEqual((double)expected,(double)actual);

        }
    }
}

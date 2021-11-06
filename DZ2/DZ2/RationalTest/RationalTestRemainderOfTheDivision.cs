using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalTest
{
    [TestClass]
    public class RationalTestRemainderOfTheDivision
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 2);
            var expected = 0;

            var actual = a % b;

            Assert.AreEqual((double)expected, (double)actual);
        }
    }
}

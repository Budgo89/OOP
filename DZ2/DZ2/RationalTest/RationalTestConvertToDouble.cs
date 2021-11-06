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
    public class RationalTestConvertToDouble
    {
        [TestMethod]
        public void TestMethod()
        {
            Rational a = new Rational(1, 2);
            double expected = 0.5;

            var actual = (double)a;

            Assert.AreEqual(expected, actual);
        }
    }
}

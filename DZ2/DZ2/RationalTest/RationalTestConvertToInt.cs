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
    public class RationalTestConvertToInt
    {
        [TestMethod]
        public void TestMethod()
        {
            Rational a = new Rational(1, 3);
            int expected = 0;

            var actual = (int)a;

            Assert.AreEqual(expected, actual);
        }
    }
}


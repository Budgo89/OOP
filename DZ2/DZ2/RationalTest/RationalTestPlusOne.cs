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
    public class RationalTestPlusOne
    {
        [TestMethod]
        public void TestMethod()
        {
            Rational a = new Rational(1, 2);
            Rational expected = new Rational(3, 2);

            var actual = ++a;

            Assert.AreEqual((double)expected, (double)actual);
        }
    }    
}

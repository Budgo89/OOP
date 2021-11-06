﻿using DZ5_rational_and_complex_number_calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalTest
{
    [TestClass]
    public class RationalTestLessThanOrEqualTo
    {
        [TestMethod]
        public void TestMethod()
        {
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 3);
            bool expected = true;

            var actual = a >= b;

            Assert.AreEqual(expected, actual);
        }
    }
}

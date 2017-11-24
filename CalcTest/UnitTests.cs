using System;
using NUnit.Framework;
using CalcTextBoxes.Models;

namespace CalcTest
{
    [TestFixture]
    public class NUnitTests
    {
        [TestCase(5, 4, "+", 9)]
        [TestCase(5, 4, "-", 1)]
        [TestCase(5, 4, "*", 20)]
        [TestCase(20, 4, "/", 5)]
        public void CalcAPITest(int a, int b, string op, int exp)
        {
            Calc c = new Calc();
            c.num1 = a;
            c.num2 = b;
            c.opr = op;
            c.CalcRes();
            Assert.AreEqual(exp, c.res);
        }
    }
}

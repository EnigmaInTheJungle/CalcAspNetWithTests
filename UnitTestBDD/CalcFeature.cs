using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LightBDD;
using LightBDD.NUnit3;
using CalcTextBoxes.Models;

namespace UnitTestBDD
{
    public partial class CalcFeature : FeatureFixture
    {
        private Calc _calculator;

        public void Given_a_calculator()
        {
            _calculator = new Calc();
        }

        public void Then_adding_X_to_Y_should_give_RESULT(int x, int y, int result)
        {
            _calculator.num1 = x;
            _calculator.num2 = y;
            _calculator.opr = "+";
            _calculator.CalcRes();
            Assert.AreEqual(result, _calculator.res);
        }

        public void Then_dividing_X_by_Y_should_give_RESULT(int x, int y, int result)
        {
            _calculator.num1 = x;
            _calculator.num2 = y;
            _calculator.opr = "/";
            _calculator.CalcRes();
            Assert.AreEqual(result, _calculator.res);
        }

        public void Then_multiplying_X_by_Y_should_give_RESULT(int x, int y, int result)
        {
            _calculator.num1 = x;
            _calculator.num2 = y;
            _calculator.opr = "*";
            _calculator.CalcRes();
            Assert.AreEqual(result, _calculator.res);
        }

        public void Then_substraction_X_by_Y_should_give_RESULT(int x, int y, int result)
        {
            _calculator.num1 = x;
            _calculator.num2 = y;
            _calculator.opr = "-";
            _calculator.CalcRes();
            Assert.AreEqual(result, _calculator.res);
        }
    }
}

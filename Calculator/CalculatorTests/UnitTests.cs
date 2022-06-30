using System;
using Calculator.Actions;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(10, 15, 25)]
        [TestCase(-25, -5, -30)]
        [TestCase(5215, -1215, 4000)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Add addition = new Add();
            double Answ = addition.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
}


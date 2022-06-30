using System;
using Calculator.Actions;
using NUnit.Framework;

namespace calc.Test
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Add addition = new Add();
            double Answ = addition.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
}
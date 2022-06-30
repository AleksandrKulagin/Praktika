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
            double Answ = addition.Addition(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
    public class SubstractionTests
    {
        [TestCase(10, 15, -5)]
        [TestCase(-25, -5, -20)]
        [TestCase(1000, -100, 1100)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Sub substraction = new Sub();
            double Answ = substraction.Substraction(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
    public class MultiplicationTests
    {
        [TestCase(10, 2, 20)]
        [TestCase(-10, -5, 50)]
        [TestCase(13, 2, 26)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Mult multiplication = new Mult();
            double Answ = multiplication.Multiplication(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
    public class DivisionTests
    {
        [TestCase(30, 3, 10)]
        [TestCase(-100, 10, -10)]
        [TestCase(50, 2, 25)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Div division = new Div();
            double Answ = division.Division(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
    public class PowTests
    {
        [TestCase(9, 2, 3)]
        [TestCase(16, 2, 4)]
        [TestCase(25, 2, 5)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            XPow pow = new XPow();
            double Answ = pow.XPowY(firstNum, secondNum);
            Assert.AreEqual(answer, Answ);
        }
    }
    public class OneDivTests
    {
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        [TestCase(8, 0.125)]
        public void CalcTest(double firstNum, double answer)
        {
            DivOnX addition = new DivOnX();
            double Answ = addition.OneDivOnX(firstNum);
            Assert.AreEqual(answer, Answ);
        }
    }
}


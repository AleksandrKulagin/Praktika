using System;
using Calculator.Actions;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class TwoArgumentsFactoryTest
    {
        [TestCase("ITwoArgumentsCalculator", typeof(Add))]
        public void CreateCalculatorTest(string name, Type type)
        {
            ITwoArgumentsCalculator calculator = new Add();
            Assert.IsInstanceOf(type, calculator);
        }
    }
}


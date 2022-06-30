using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Actions;

namespace Calculator.Actions
{
    public class XPow : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }

        public double XPowY(double x, double y)
        {
            return Math.Pow(x, 1 / y);
        }
    }
}
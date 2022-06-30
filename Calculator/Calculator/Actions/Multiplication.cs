using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Actions
{
    public class Mult : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }
    }
}

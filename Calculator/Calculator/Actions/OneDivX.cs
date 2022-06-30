using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Actions
{
    public class DivOnX : ITwoArgumentsCalculator
    {
        public double Calculate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }

        public double OneDivOnX(double x)
        {
            return 1 / x;
        }
    }
}

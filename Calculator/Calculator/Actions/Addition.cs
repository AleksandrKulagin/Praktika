using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Properties;


namespace Calculator.Actions
{
    public class Add : ITwoArgumentsCalculator
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Calculate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }
    }
}
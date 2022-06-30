using Calculator.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class TwoArgumentsFactory
    {
        public static double firstNum, secondNum;
        public static double Creatror(string calculatorName)

        {
            switch (calculatorName)
            {
                case "btnPlus":
                    var add = new Add(); // Новый экземпляр класса Add
                    return add.Addition(firstNum, secondNum); // Выводим результат x+y
                case "btnMinus":
                    var sub = new Sub(); // Новый экземпляр класса Sub
                    return sub.Substraction(firstNum, secondNum); // Выводим результат x-y
                case "btnMultiple":
                    var mult = new Mult(); // Новый экземпляр класса Mult
                    return mult.Multiplication(firstNum, secondNum); // Выводим результат x*y
                case "btnDiv":
                    var div = new Div(); // Новый экземпляр класса Div
                    return div.Division(firstNum, secondNum); // Выводим результат x:y
                case "btnDivX":
                    var divx = new DivOnX(); // Новый экземпляр класса DivOnX
                    return divx.OneDivOnX(firstNum); // Выводим результат 1:x
                case "btnXPow":
                    var pow = new XPow(); // Новый экземпляр класса XPow
                    return pow.XPowY(firstNum, secondNum);  // Выводим результат x^(1/y)
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

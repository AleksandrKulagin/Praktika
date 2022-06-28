using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Actions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double x; // x - первое число
        double y; // y - второе число

        public Form1()
        {
            InitializeComponent();
        }

        private void ALLClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnPlus":
                    var add = new Add(); // Новый экземпляр класса Add
                    lbRes.Text = Convert.ToString(add.Addition(x, y)); // Выводим результат x + y
                    if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
                    {
                        lbRes.Text = "";
                        MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "btnMinus":
                    var sub = new Sub(); // Новый экземпляр класса Sub
                    lbRes.Text = Convert.ToString(sub.Substraction(x, y)); // Выводим результат x - y
                    if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
                    {
                        lbRes.Text = "";
                        MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "btnMultiple":
                    var mult = new Mult(); // Новый экземпляр класса Mult
                    lbRes.Text = Convert.ToString(mult.Multiplication(x, y)); // Выводим результат x * y
                    if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
                    {
                        lbRes.Text = "";
                        MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "btnDiv":
                    var div = new Div(); // Новый экземпляр класса Div
                    lbRes.Text = Convert.ToString(div.Division(x, y)); // Выводим результат x / y
                    if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
                    {
                        lbRes.Text = "";
                        MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "btnDivX":
                    var divx = new DivOnX(); // Новый экземпляр класса DivOnX
                    lbRes.Text = Convert.ToString(divx.OneDivOnX(x, y)); // Выводим результат 1/x
                    if (tbOne.Text == "")
                    {
                        MessageBox.Show("Не указано значение аргумента Х", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Вывод ошибки, если поле x пустое
                    }
                    break;
                case "btnXPow":
                    var pow = new XPow(); // Новый экземпляр класса XPow
                    lbRes.Text = Convert.ToString(pow.XPowY(x, y)); // Выводим результат x^(1/y)
                    if (tbOne.Text == "")
                    {
                        MessageBox.Show("Не указано значение аргумента Х", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (tbTwo.Text == "")
                    {
                        MessageBox.Show("Не указано значение аргумента Y", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

        public void tbOne_TextChanged(object sender, EventArgs e)
        {

            if (tbOne.Text == "")
            {
                x = 0; // Зануляем переменную x, если первое поле ввода пустое
            }
            else
            {
                x = Convert.ToDouble(tbOne.Text); // иначе преобразуем введенные данные в тип Double
            }
        }

        public void tbTwo_TextChanged(object sender, EventArgs e)
        {
            if (tbTwo.Text == "")
            {
                y = 0; // Зануляем переменную y, если второе поле ввода пустое
            }
            else
            {
                y = Convert.ToDouble(tbTwo.Text); // иначе преобразуем введенные данные в тип Double
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // При нажатии кнопки С (очистить) зануляем переменные x и y, и очищаем поля с введенными данными и результатом
        {
            x = 0;
            y = 0;
            tbOne.Text = Convert.ToString("");
            tbTwo.Text = Convert.ToString("");
            lbRes.Text = Convert.ToString("");
        }

        private void button1_Click(object sender, EventArgs e) // Инвертирует число x
        {
            tbOne.Text = Convert.ToString(x * -1);
        }

        private void button2_Click(object sender, EventArgs e) // Инвертирует число y
        {
            tbTwo.Text = Convert.ToString(y * -1);
        }

        private void tbOne_KeyPress(object sender, KeyPressEventArgs e) // Ограничения на ввод в tbOne
        {
            if (e.KeyChar == ((char)Keys.Back) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar >= '0' && e.KeyChar <= '9') // Считываем введенный символ
            {
                if (e.KeyChar == '.') e.KeyChar = ','; // Замена вводимой . на , в первом поле
                if (e.KeyChar == '0' && tbOne.Text == "0") e.Handled = true; // Запрет возможности ввода нескольких нолей
                if (e.KeyChar == ',' && tbOne.Text.IndexOf(',') > -1) e.Handled = true; // Запрет ввода нескольких ,
            }
            else e.Handled = true;
        }

        private void tbTwo_KeyPress(object sender, KeyPressEventArgs e) // Ограничения на ввод в tbTwo
        {
            if (e.KeyChar == ((char)Keys.Back) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar >= '0' && e.KeyChar <= '9') // Считываем введенный символ
            {
                if (e.KeyChar == '.') e.KeyChar = ',';  // Замена вводимой . на , во втором поле 
                if (e.KeyChar == '0' && tbTwo.Text == "0") e.Handled = true; // Запрет возможности ввода нескольких нолей
                if (e.KeyChar == ',' && tbTwo.Text.IndexOf(',') > -1) e.Handled = true; // Запрет ввода нескольких ,
            }
            else e.Handled = true;
        }
    }
}
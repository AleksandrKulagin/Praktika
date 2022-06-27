using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lbRes.Text = Convert.ToString(x - y); // Выводим результат x - y
            if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
            {
                lbRes.Text = "";
                MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            lbRes.Text = Convert.ToString(x * y); // Выводим результат x * y
            if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
            {
                lbRes.Text = "";
                MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lbRes.Text = Convert.ToString(x / y); // Выводим результат x / y
            if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
            {
                lbRes.Text = "";
                MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lbRes.Text = Convert.ToString(x + y); // Выводим результат x + y
            if ((tbOne.Text == "") || (tbTwo.Text == "")) // Если какое-то из полей пустое выводим ошибку
            {
                lbRes.Text = "";
                MessageBox.Show("Введены неверные значения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnDivX_Click(object sender, EventArgs e)
        {
            if (tbOne.Text == "")
            {
                MessageBox.Show("Не указано значение аргумента Х", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Вывод ошибки, если поле x пустое
            }
            lbRes.Text = Convert.ToString(1 / x);
        }

        private void btnXPow_Click(object sender, EventArgs e) // Если поле Х или Y пустое, выводим соответсвующую ошибку
        {
            if (tbOne.Text == "")
            {
                MessageBox.Show("Не указано значение аргумента Х", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tbTwo.Text == "")
            {
                MessageBox.Show("Не указано значение аргумента Y", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lbRes.Text = Convert.ToString(Math.Pow(x, (1 / y)));
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
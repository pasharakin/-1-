using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_13;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очищаем текстобксы на случай если расчет уже осуществлялся
            textBoxNumbers.Text = "";
            textBoxRezults.Text = "";
            // вызываем функцию из библиотеки
            Lib_13.SqrAndSqrt.Work(textBoxNumbers, textBoxRezults);
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очищаем текстбоксы
            textBoxNumbers.Text = "";
            textBoxRezults.Text = "";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ракин ИСП-31 Практическая-1 Вариант-13.\nГенерировать случайные числа Х, распределенные в диапазоне от -5 до 5 и вычислять для чисел > 0 X, " +
                "а для чисел < 0 функцию x2.Вычисления прекратить, когда подряд появится два одинаковых случайных числа." +
                "На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

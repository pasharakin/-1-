using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_13
{
    public static class SqrAndSqrt
    {
        public static void Work(TextBox numbers, TextBox rezults)
        {
            Random random = new Random();

            int a = random.Next(-5, 5);
            int b = random.Next(-5, 5);

            double aRez,
                   bRez;
            // вывели первые 2 сгенерированных числа
            numbers.Text = Convert.ToString(a) + " " + Convert.ToString(b) + " ";
            // ищем квадрат или корень для них по условию
            if (a < 0)
            {
                aRez = a * a;
            }
            else if (a > 0) 
            {
                aRez = Math.Round(Math.Sqrt(a), 3);
            }
            else
            {
                aRez = 0;
            }
            if (b < 0)
            {
                bRez = b * b;
            }
            else if (b > 0)
            {
                bRez = Math.Round(Math.Sqrt(b), 3);
            }
            else
            {
                bRez = 0;
            }
            // выводим результат
            rezults.Text = Convert.ToString(aRez) + " " + Convert.ToString(bRez) + " ";
            // заходим в цикл чтобы генерировать числа дальше ПОКА НЕ встретится 2 одинаковых числа
            while (a != b) 
            {
                // поменяли значение а на б
                a = b;
                // б сгенерировали
                b = random.Next(-5, 5);
                // вывели
                numbers.Text += Convert.ToString(b) + " ";
                // считаем по условию
                if (b < 0)
                {
                    bRez = b * b;
                }
                else if (b > 0)
                {
                    bRez = Math.Round(Math.Sqrt(b), 3);
                }
                else
                {
                    bRez = 0;
                }
                // выводим результат
                rezults.Text += Convert.ToString(bRez) + " ";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartynukGit
{
    internal class Program
    {
        static void Main()
        {
            // Объявляем переменные a, b и c
            double a, b, c;

            // Вводим значения для переменных a и b
            Console.WriteLine("Введите значение для a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение для b:");
            b = Convert.ToDouble(Console.ReadLine());

            // Вычисляем сумму переменных a и b
            c = a + b;

            // Выводим результат на экран
            Console.WriteLine("Сумма a и b равна: " + c);
        }
    }
}

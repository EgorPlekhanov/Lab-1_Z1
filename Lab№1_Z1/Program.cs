using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Вариант 19 ==");
            Console.WriteLine("__ Задание А __");
            Console.Write("Введите n: ");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            decimal m = decimal.Parse(Console.ReadLine());
            if (m == 1)
                Console.WriteLine("Нельзя вычислить (деление на 0)");
            else
            {
                decimal res = n++ / --m;
                res++;
                Console.WriteLine("n = {0}, m = {1}, (n++/--m)++ = {2}", n, m, res);
            }
            bool res2 = ++m < n--;
            Console.WriteLine("n = {0}, m = {1}, ++m < n-- = {2}", n, m, res2);
            bool res3 = --m > ++n;
            Console.WriteLine("n = {0}, m = {1}, --m > ++n = {2}", n, m, res3);
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());
            double res4 = 7 * Math.Atan(x * x);
            Console.WriteLine("x = {0}, y = {1}, res = {2:f5}", x, y, res4);
        }
    }
}

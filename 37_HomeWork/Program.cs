using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine());

            //if (a > b)
            //    Console.WriteLine($"Число {a} больше числа {b} ");
            //else if (b > a)
            //    Console.WriteLine($"Число {b} больше числа {a} ");
            //else if (a == b)
            //    Console.WriteLine($"Числа {a} = {b} ");
            //else
            //    Console.WriteLine("Неверное значение!");
            //Console.ReadKey();


            int maxValue = a > b ? a : b;
            Console.WriteLine($"Максимальное значение: { maxValue}");
            Console.ReadKey();
        }
    }
}

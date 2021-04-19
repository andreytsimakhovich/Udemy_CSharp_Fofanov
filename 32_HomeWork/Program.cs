using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны треугольника №1:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение стороны треугольника №2:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение стороны треугольника №3:");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            
            Console.WriteLine($"Площадь треугольника: {Math.Round(S, 2)}");
            Console.ReadKey();
        }
    }
}

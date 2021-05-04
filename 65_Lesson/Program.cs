using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Enter values for triangle: ");
            double S = calc.triangleArea(double.Parse(Console.ReadLine()));
            Console.WriteLine("Area of the triagle = " + S);
            Console.ReadKey();
        }
    }
}

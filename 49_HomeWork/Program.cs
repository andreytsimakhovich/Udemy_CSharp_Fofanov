using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate the factorial:");
            int number = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("Calculation result: " + factorial);

            Console.ReadKey();
        }
    }
}

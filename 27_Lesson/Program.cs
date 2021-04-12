using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3)); // возведение числа в степень

            Console.WriteLine(Math.Sqrt(9)); // корень
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.3));  // округление числа
            Console.WriteLine(Math.Round(1.9));

            Console.WriteLine();
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));

        }
    }
}

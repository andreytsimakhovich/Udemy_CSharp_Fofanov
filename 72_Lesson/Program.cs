using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_Lesson
{
    class Program
    {
        //static void Sum(int x, int y, out int a)
        //{
        // a = x + y;
        //}
        //static void Main(string[] args)
        //{
        //    int z;
        //    Sum(1, 2, out z);

        //    Console.WriteLine(z);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number, please:");

            string str = Console.ReadLine();

            bool wasParsed = int.TryParse(str, out int number);

            if (wasParsed)
                Console.WriteLine("The number is " + number);
            else
                Console.WriteLine("Failed to parse!");

            Console.ReadKey();
        }
    }
}

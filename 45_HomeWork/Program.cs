using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Fibonacci numbers you need to generate:");
            int number = int.Parse(Console.ReadLine());

            int[] fibonacci = new int [number];

            int a1 = 0;
            int a2 = 1;

            fibonacci[0] = a1;
            fibonacci[1] = a2;

            for (int i = 2; i < number; i++)
            {
                int a = a1 + a2;
                fibonacci[i] = a;

                a1 = a2;
                a2 = a;
            }

            foreach (var cur in fibonacci)
            {
                Console.Write(cur + " "); ;
            }

            Console.ReadLine();
        }
    }
}

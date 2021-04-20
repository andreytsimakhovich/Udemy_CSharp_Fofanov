using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
       
           
            Console.WriteLine("Enter 10 positive integers:");

            int[] num = new int[10];

            int inputCount = 0;
            while(inputCount<10)
            {
                int n = int.Parse(Console.ReadLine());
                num[inputCount] = n;

                inputCount++;

                if (n == 0)
                    break;
            }

            int sum = 0;
            int count = 0;

            foreach (int i in num)
            {
                
                if (i % 3 == 0 && i > 0)
                {
                    sum += i;
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine();
            Console.WriteLine($"The average value of positive integers that are multiples of three is {average}.");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // continue
            int[] numbers2 = { 0, 10, 8, 7, 4, 1, 5, 2, 3, 6, 9 };
            foreach (var x in numbers2)
            {
                if (x % 2 != 0)
                    continue;
                Console.Write(x + " ");
            }

            Console.ReadKey();

            // break
            int[] numbers = { 0, 10, 8, 7, 4, 1, 5, 2, 3, 6, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number = {numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write(letters[j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

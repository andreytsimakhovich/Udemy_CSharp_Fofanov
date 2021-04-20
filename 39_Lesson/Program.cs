using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)  // вывод в обратном порядке
                Console.Write(numbers[i] + " ");

            Console.WriteLine();

            for (int i = 0; i <numbers.Length; i++) // вывод четных чисел
            {
                if (numbers[i] % 2 == 0)
                    Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++) // вывод нечетных чисел
            {
                if (numbers[i] % 2 == 1)
                    Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            foreach (var j in numbers)
            {
                Console.Write(j + " ");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCopy:");

            int[] array2 = new int[10];
            array1.CopyTo(array2, 0);   // копирование массива array1 to array2
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nRevers:");

            Array.Reverse(array1);
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nSort:");

            Array.Sort(array1);
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nClear:");

            Array.Clear(array1, 0, array1.Length);
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

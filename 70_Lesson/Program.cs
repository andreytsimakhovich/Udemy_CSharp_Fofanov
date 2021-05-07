using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_Lesson
{
    class Program
    {
        static void Array(string str, params int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            Array("hello", 1, 2, 3, 4, 5);
            Console.ReadLine();
        }
    }
}

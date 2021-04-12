using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a3 = { -1, 2, 100, -100, 0, 5 };
            Console.WriteLine(a3[3]);
        }
    }
}

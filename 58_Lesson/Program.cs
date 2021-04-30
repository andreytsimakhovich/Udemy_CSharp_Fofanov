using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[4][];
            myArray[0] = new int[1];
            myArray[1] = new int[3];
            myArray[2] = new int[2];
            myArray[3] = new int[5];

            Console.WriteLine("Enter numbers:");

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    myArray[i][j] = int.Parse(st);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Output of values:");

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

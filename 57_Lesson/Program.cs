using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
            }

            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

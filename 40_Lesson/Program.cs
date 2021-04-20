using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { -1, 1, 2, 3, 7, -7, -2, 9, -4, -8, 0, 4, 9, 7, 9, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1 ; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Пары: ({atI};{atJ}). Indexes({i};{j})");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

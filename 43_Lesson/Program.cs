using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Сделайте выбор:");
                int month = int.Parse(Console.ReadLine());
                string season = string.Empty;

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "Winter";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = "Spring";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = "Summer";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = "Autumn";
                        break;
                    default:
                        season = "Неверное значение!";
                        break;
                }
                Console.WriteLine(season);
                Console.WriteLine();
            }
        }
    }
}

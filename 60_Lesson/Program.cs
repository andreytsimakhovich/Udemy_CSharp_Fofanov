using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            Console.WriteLine("Please, enter damage:");
            int value = int.Parse(Console.ReadLine());
            c.Hit(value);
            Console.WriteLine("Value of health:" + c.Health);
            Console.ReadKey();
        }
    }
}

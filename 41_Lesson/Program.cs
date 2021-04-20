using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            while (age < 18)
            {
                Console.WriteLine("Enter your age:");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Ты еще мелкий!");
                Console.Clear();
            }
            Console.WriteLine("Добро пожаловать в клуб!");
            Console.ReadLine();
        }
    }
}

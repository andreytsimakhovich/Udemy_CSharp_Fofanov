using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height:");
            double height = double.Parse(Console.ReadLine());
            Console.Clear();

            double bodyMassIndex = weight / weight * height;

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex >18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex >  30;

            bool isFat = isAboveNormal || isTooFat;
            
            Console.WriteLine(bodyMassIndex);

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");
            }

            else
            {
                Console.WriteLine("You're in a good shape");
            }
            
            Console.ReadLine();
        }
    }
}

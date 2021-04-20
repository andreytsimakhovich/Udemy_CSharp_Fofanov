using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_HomeWork
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your lastname:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height:");
            double height = double.Parse(Console.ReadLine());
            Console.Clear();

            double bodyMassIndex = weight / height * height;

            string profile =
                  $"Your profile: {Environment.NewLine}"
                + $"Full Name: {lastname} {firstname} {Environment.NewLine}"
                + $"Age: {age}{Environment.NewLine}"
                + $"Weight: {weight}{Environment.NewLine}"
                + $"Height: {height}{Environment.NewLine}"
                + $"Body Mass Index: {bodyMassIndex}{Environment.NewLine}";

            Console.WriteLine(profile);
            Console.ReadKey();
        }
    }
}

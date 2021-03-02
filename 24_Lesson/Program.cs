using System;

namespace _24_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Please, tell me your age");
            
            string input = Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine($"Your age is {age}");

            Console.BackgroundColor = ConsoleColor.Cyan;
        }
    }
}

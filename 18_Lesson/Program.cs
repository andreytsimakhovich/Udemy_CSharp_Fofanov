using System;

namespace _18_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "abracadabra";
            bool containtsA = name.Contains("a");
            Console.WriteLine(containtsA);
        
            bool containtsB = name.Contains("E");
            Console.WriteLine(containtsB);

            bool endswithAbra = name.EndsWith("abra");
            Console.WriteLine(endswithAbra);

            bool startwithAbra = name.StartsWith("abra");
            Console.WriteLine(startwithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine($"Первый символ a: {indexOfA}");

            int lastIndexOfB = name.LastIndexOf('b');
            Console.WriteLine($"Последний символ b: {lastIndexOfB}");

            Console.WriteLine($"Длина строки: {name.Length}");

            string substrFrom5 = name.Substring(5);
            Console.WriteLine(substrFrom5);

            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine(substrFromTo);


        }
    }
}

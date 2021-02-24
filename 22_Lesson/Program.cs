using System;
using System.Threading;

namespace _22_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Andrey";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}!", name, age);
            Console.WriteLine(str1);

            string str2 = $"My name is {name} and I'm {age}!";
            Console.WriteLine(str2);

            string str3 = "My name is \nAndrey!";
            Console.WriteLine(str3);
            str3 = $"My name is {Environment.NewLine}Andrey!";
            Console.WriteLine(str3);

            string str4 = @"c:\temp\data";
            Console.WriteLine(str4);

            double money = 12.8;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string result = $"{money:C2}";
            Console.WriteLine(result);
        } 
    }
}

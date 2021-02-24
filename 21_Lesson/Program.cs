using System;
using System.Text;

namespace _21_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Хорошо использовать для сложения большого количества строк
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Andrey!");
            sb.Append("!");
            sb.Append("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}

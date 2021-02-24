using System;

namespace _19_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty; // same as ""
            //string emphy = "";
            //string whiteSpased = " ";
            //string notEmphy = " b";
            //string nullStr = null;

            //Console.WriteLine("IsNullOrEmphy");
            //bool isNullOrEmphy = string.IsNullOrEmpty(emphy);
            //Console.WriteLine(isNullOrEmphy);

            //isNullOrEmphy = string.IsNullOrEmpty(whiteSpased);
            //Console.WriteLine(isNullOrEmphy);

            //isNullOrEmphy = string.IsNullOrEmpty(notEmphy);
            //Console.WriteLine(isNullOrEmphy);

            //isNullOrEmphy = string.IsNullOrEmpty(nullStr);
            //Console.WriteLine(isNullOrEmphy);

            //Console.WriteLine("\nIsNullOrWhiteSpased");
            //bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpased);
            //Console.WriteLine(isNullOrWhiteSpace);

            //isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullStr);
            //Console.WriteLine(isNullOrWhiteSpace);


            string a = "";

            bool result = string.IsNullOrEmpty(a);
            Console.WriteLine(result);

            result = string.IsNullOrWhiteSpace(a);
            Console.WriteLine(result);
        }
    }
}

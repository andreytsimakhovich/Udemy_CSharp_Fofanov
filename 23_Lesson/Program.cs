using System;

namespace _23_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "abcde";
            //string str2 = "abcde";

            //bool areEquel = str1 == str2;
            //Console.WriteLine(areEquel);

            //areEquel = string.Equals(str1, str2, StringComparison.);
            //Console.WriteLine(areEquel);

            string str1 = "Strasse";
            string str2 = "Straße";

            bool areEquel = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEquel);

            areEquel = string.Equals(str1, str2, StringComparison.InvariantCulture);
            Console.WriteLine(areEquel);

            areEquel = string.Equals(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine(areEquel);

            string str3 = "asdF";
            string str4 = "asdf";

            bool result = string.Equals(str3, str4, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(result);
        }
    }
}

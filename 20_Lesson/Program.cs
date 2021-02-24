using System;

namespace _20_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Andrey!");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "Andrey!");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 12);
            Console.WriteLine(nameConcat);

            string replace = nameConcat.Replace('n', 'N');
            Console.WriteLine(replace);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            //string a = "My name is Andrey";   пример сравнения символов строк без регистрозависимости
            //string b = "MY NAME is Andrey";

            //a = a.ToUpper();
            //b = b.ToUpper();

            //bool result = a == b;
            //Console.WriteLine(result);

            string str = "   my name is Andrey   ";
            Console.WriteLine(str.Trim());

        }
    }
}

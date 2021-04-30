using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine("StartingIndex:" + myArray.GetLowerBound(0));
            Console.WriteLine("EndingIndex:" + myArray.GetUpperBound(0));

            Console.WriteLine();

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0) ; i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }

            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

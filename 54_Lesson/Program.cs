using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 4, 5, 12, 2, 17, 12, 18, 19, 2 };
            intList.Add(7);
            Console.WriteLine("Sourse array:");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);  // Добавление intArray к intList
            Console.WriteLine("Add intArray to intList:");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            if (intList.Remove(1))  // Удаляет первую "1" в массиве
                Console.WriteLine("Item deleted...");

            else
                Console.WriteLine("Item wasn't found...");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            intList.RemoveAt(0);
            Console.WriteLine("Deleted Index 0:");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            intList.Reverse();
            Console.WriteLine("Reverse intList array:");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            bool contains = intList.Contains(3);
            Console.WriteLine("Presence '3' is " + contains);

            int min = intList.Min();
            int max = intList.Max();
            Console.WriteLine($"min= {min} max= {max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);
            Console.WriteLine($"IndexOf = {indexOf}, lastIndexOf = {lastIndexOf}");

            Console.WriteLine("Output using cycle FOR:");
            for (int i = 0; i < intList.Count; i++) // calling intList using cycle For
            {
                Console.Write($"{intList[i]} ");
            }

            Console.ReadLine();

        }
    }
}

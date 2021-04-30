using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = new Dictionary<int, string>();
            //people.Add(1, "Jack");
            //people.Add(2, "Andy");
            //people.Add(3, "Lana");

            var people = new Dictionary<int, string>()
            {
                {1, "Olya"},
                {2, "Andrey"},
                {3, "Dima"},
                {4, "Alex"},
                {5, "Julia"},
            };

            var number = new Dictionary<int, string>()
            {
                {1, "+375293692514"},
                {2, "+375297778064"},
                {3, "+79090819442"},
                {4, "+375299875421"},
                {5, "+375297907717"},
            };

            var keys = people.Keys;
            foreach (var item in keys)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            
            var values = people.Values;
            foreach (var item in values)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine();

            foreach (var pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            Console.WriteLine();

            Console.WriteLine($"Count: {people.Count}");

            Console.WriteLine(people.ContainsKey(2));

            Console.ReadKey();
        }
    }
}

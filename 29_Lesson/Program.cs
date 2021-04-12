using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToString());

            DateTime dt = new DateTime(2016, 2, 28);
            Console.WriteLine(dt);

            DateTime newDt = dt.AddDays(2);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            Console.WriteLine(ts.Days);
        }
    }
}

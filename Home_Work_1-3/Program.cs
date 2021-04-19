using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1_3
{
    class Program
    {

        static int Foo(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;

            int nextValue = value / 10;

            return digit + Foo(nextValue);
        }
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Введите имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Ваше имя:" + name);
            //Console.ReadKey();

            //2
            //Console.WriteLine("Введите два целых числа:");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Число 1:    {x}\nЧисло 2:    {y} ");
            //Console.WriteLine("Замена чисел:");
            //Console.WriteLine($"Число 1:    {y}\nЧисло 2:    {x} ");

            //3
            int myValue = 156;

            int result = Foo(myValue);

            Console.WriteLine(result);
        }
    }
}

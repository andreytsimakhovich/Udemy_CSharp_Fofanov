using System;

namespace _13_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;

            bool argsEqual = a == b;
            Console.WriteLine(argsEqual);
        }

        static void MathOperations()
        {
            //Взятие остатка от числа

            int x;
            x = 4 % 2;
            Console.WriteLine(x);
            x = 5 % 2;
            Console.WriteLine(x);

            // Умножение

            int a;
            a = 2 * 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);
        }
        static void IncrementDecrement()
        {
            // Самое простое и доходчивое объяснение инкремента в постфиксном и префискном представлении
            int x = 0;
            int y = x++;
            Console.WriteLine($"Значение Y: {y}");
            Console.WriteLine($"Значение X: {x}\n");

            y = ++x;
            Console.WriteLine($"Значение Y: {y}");
            Console.WriteLine($"Значение X: {x}\n");

            x += 2;
            // x = x + 2;
            Console.WriteLine($"x + 2 = {x}");
            x -= 3;
            // x = x - 3;
            Console.WriteLine($"x - 3 = {x}");

            x = 2;
            y = x--;
            Console.WriteLine($"Значение Y: {y}");
            Console.WriteLine($"Значение X: {x}\n");

            y = --x;
            Console.WriteLine($"Значение Y: {y}");
            Console.WriteLine($"Значение X: {x}\n");



        }
    }
}

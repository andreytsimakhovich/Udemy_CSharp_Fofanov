using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Count:" + stack.Peek());

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            stack.Pop();

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var queue = new Queue<int>();
            
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("Count:" + queue.Peek());
            
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

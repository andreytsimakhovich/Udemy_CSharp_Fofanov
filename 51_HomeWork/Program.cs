using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Enter your login:");
                string login = Console.ReadLine();

                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                    if (login == "andrey" && password == "1234")
                    {
                        Console.WriteLine("Enter the system!");
                        break;
                    }
                    else
                    {
                        counter++;

                        if (counter < 3)
                            Console.WriteLine("The username or password is incorrect! Try again.");
                        else
                        {
                            Console.WriteLine("The number of available tries have been exceeded!");
                            break;
                        }
                    }
            }
            Console.ReadLine();
        }
    }
}

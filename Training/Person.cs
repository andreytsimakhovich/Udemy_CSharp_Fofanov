using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name; 
        }

        public abstract void Display();
    }

    class Client : Person
    {
        public int Sum { get; set; }

        public Client(string name, int sum) : base(name)
        {
            Sum = sum;
        }

        public override void Display()
        {
            Console.WriteLine($"У клиента {Name} на счету {Sum} $");
        }
    }

    class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string name, string position) : base(name)
        {
            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine($"Сотрудник {Name} на должности {Position}");
        }
    }
}

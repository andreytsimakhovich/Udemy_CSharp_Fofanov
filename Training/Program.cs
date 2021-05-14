using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client("Andrey", 10000);    // for Person class
            //client.Display();

            //Employee employee = new Employee("Viktor", "Оператор");
            //employee.Display();


            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(30, 20, 10);
            shapes[1] = new Rectangle(10, 20);

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
                Console.WriteLine(shape.Area());
            }
        }

        static void Do(Shape shape)
        {
            shape.Area();
        }
    }
}

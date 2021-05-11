using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTerminal bank = new BankTerminal("123");

            bank.Connect();

            ModelXTerminal model = new ModelXTerminal("234");

            model.Connect();

            BankTerminal bm = new ModelXTerminal("9182391");

            bm.Connect();
        }
    }
}

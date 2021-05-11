using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Lesson
{
    public class BankTerminal
    {

        protected string id = "bt-001";

        public virtual void Connect()
        {
            Console.WriteLine("Connecting the terminal...");
        }
    }

    public class ModelXTerminal: BankTerminal
    {
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine(id);
        }
    }
}

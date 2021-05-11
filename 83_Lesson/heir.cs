using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Lesson
{
    public class BankTerminal
    {

        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("Connecting the terminal...");
        }
    }

    public class ModelXTerminal: BankTerminal
    {
        public ModelXTerminal(string id): base(id)
        {

        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine(id);
        }
    }
}

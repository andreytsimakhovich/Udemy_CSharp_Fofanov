using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Lesson_2_
{
    public class Sedecal
    {
        protected string voltage;
        public Sedecal(string voltage)
        {
          this.voltage = voltage;
        }
        public virtual void Connection()
        {
            Console.WriteLine("Connection to the generator...");
            Console.WriteLine("Connection success...");

        }
    }

    public class VJ : Sedecal
    {
        public VJ(string voltage) : base(voltage)  
        {
        }
        public override void Connection()
        {
            base.Connection();
            Console.WriteLine("WarmUp Tube...");
        }
    }
}

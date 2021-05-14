using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Lesson_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedecal sedecal = new Sedecal("80");
            VJ vJ = new VJ("100");

            sedecal.Connection();

            vJ.Connection();
        }
    }
}

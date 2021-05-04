using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_Lesson
{
    public class Calculator
    {
        public double triangleArea (double a, double b)
        {
           return 0.5 * a * b;
        }

        public double triangleArea(double a)
        {
            return Math.Round((Math.Sqrt(3) / 4) * Math.Pow(a, 2), 2);
        }

        public double triangleArea(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
    }
}

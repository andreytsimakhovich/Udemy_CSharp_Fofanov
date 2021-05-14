﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("The shape is created...");
        }
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine("The triangle is created...");
        }
        public override double Area()
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing triangle...");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("The rectangle is created...");
        }
        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }

        public override double Perimeter()
        {
            return (width + height) * 2;
        }
    }
}

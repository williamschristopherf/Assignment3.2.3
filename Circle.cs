using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._3
{
    internal struct Circle
    {
        public double radius;
        public double area;

        public Circle(double r)
        {
            radius = r;
            area = 3.1415 * r * r;
        }

        public static double operator +(Circle a, Circle b)
        {
            return a.area + b.area;
        }

        public static double operator -(Circle a, Circle b)
        {
            return a.area - b.area;
        }
    }
}

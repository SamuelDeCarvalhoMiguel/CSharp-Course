using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOP
{
    internal class Rectangle
    {

        public double Height;
        public double Width;

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter(double a, double b)
        {
            return a * 2 + b * 2;
        }

        public double Diagonal(double Height, double Width)
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        }

    }
}

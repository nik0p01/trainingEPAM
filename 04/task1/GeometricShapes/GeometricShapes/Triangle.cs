using System;

namespace GeometricShapes
{
    internal class Triangle : IGeometricShape
    {
        public double C { get; set; }
        public double B { get; set; }
        public double A { get; set; }
        public Triangle(double a, double b, double c)
        {
            C = c;
            B = b;
            A = a;
        }

        public double Area()
        {
            var halfP = Perimeter() / 2;
            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }

        public double Perimeter()
        {
            return (A + B + C);
        }
    }
}

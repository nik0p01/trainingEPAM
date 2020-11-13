using System;

namespace GeometricShapes
{
    class Circle : IGeometricShape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public double Area()
        {
            return Math.PI * R * R;
        }

        public double Perimeter()
        {
            return Math.PI * R * 2;
        }
    }
}

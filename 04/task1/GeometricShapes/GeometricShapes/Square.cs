using System;

namespace GeometricShapes
{
    class Square : IGeometricShape
    {
        public double A { get; set; }
        public Square(double a)
        {
            A = a;
        }
        public virtual double Area()
        {
            return A * A;
        }

        public virtual double Perimeter()
        {
            return A * 4;
        }
    }
}

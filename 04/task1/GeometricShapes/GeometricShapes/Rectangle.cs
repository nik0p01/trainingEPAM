namespace GeometricShapes
{
    internal class Rectangle : IGeometricShape
    {
        public double B { get; set; }
        public double A { get; set; }
        public Rectangle(double a, double b)
        {
            B = b;
            A = a;
        }

        public double Area()
        {
            return A * B;
        }

        public double Perimeter()
        {
            return (A + B) * 2;
        }
    }
}

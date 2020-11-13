using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleHelper
{
    public class Rectangle
    {
       private double h;
        private double w;



        public Rectangle(double h, double w)
        {
            if (h<0 || w<0)
            {
                throw new Exception("Высота и ширина прямоугольника обязательно должны быть положительными числами");
            }
            this.h = h;
            this.w = w;
        }

        public double Perimeter()
        {
            return (w + h) * 2;
        }
        public double Square()
        {
            return w * h;
        }

    }
}

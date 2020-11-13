using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleHelper
{
    public class Rectangle
    {
       private double _height;
        private double _width;



        public Rectangle(double height, double widthw)

        {
            if (height < 0 || widthw < 0)
            {
                throw new Exception("Высота и ширина прямоугольника обязательно должны быть положительными числами");
            }
            _height = height;
            _width = widthw;
        }

        public double Perimeter()
        {
            return (_width + _height) * 2;
        }
        public double Square()
        {
            return _width * _height;
        }

    }
}

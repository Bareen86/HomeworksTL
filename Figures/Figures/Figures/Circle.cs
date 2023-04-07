using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Mylib.Interfaces;

namespace Figures.Mylib
{
    public class Circle : Shape, IShape
    {
        
        private double _radius;
        private double _area;
        private double _perimeter;
        public Circle(double radius)
        {
            ValidateRadius(radius);
            _radius = radius;
        }

        public double CalculateArea()
        {
            ValidateRadius(_radius);
            _area = 3.14 * _radius * _radius;
            ValidateArea(_area);
            return _area;
        }

        public double CalculatePerimeter()
        {
            ValidateRadius(_radius);
            _perimeter = 2 * 3.14 * _radius;
            ValidatePerimeter(_perimeter);
            return _perimeter;
        }

        private void ValidateRadius(double _radius)
        {
            if (_radius < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}

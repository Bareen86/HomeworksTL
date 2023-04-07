using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Mylib.Interfaces;

namespace Figures.Mylib
{
    public class Triangle : Shape, IShape
    {
        private double _area;
        private double _perimeter;
        private double _a;
        private double _b;
        private double _c;
        
        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            _a = a;
            _b = b;
            _c = c; 
        }

        public double CalculateArea()
        {
            ValidateSides(_a, _b, _c);
            double halfPerimeter = (_a + _b + _c) / 2;
            _area = Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _b) *(halfPerimeter - _c));
            ValidateArea(_area);
            return _area;
        }
            
        public double CalculatePerimeter()
        {
            ValidateSides(_a, _b, _c);
            _perimeter = _a + _b + _c;
            ValidatePerimeter(_perimeter);
            return _perimeter;
        }

        private void ValidateSides(double a, double b, double c)
        {
            if ((a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                throw new ArgumentException();
            }
        }
    }
}

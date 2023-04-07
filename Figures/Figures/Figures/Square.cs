using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Mylib.Interfaces;

namespace Figures.Mylib
{
    public class Square : Shape, IShape
    {
        private double _a;
        private double _area;
        private double _perimeter;
        public Square(double a)
        {
            ValidateSide(a);
            _a = a;
            
        }

        public double CalculateArea()
        {
            ValidateSide(_a);
            _area = _a * _a;
            ValidateArea(_area);
            return _area;
        }

        public double CalculatePerimeter()
        {
            _perimeter = 4 * _a;
            ValidatePerimeter(_perimeter);
            return _perimeter;
        }

        private void ValidateSide(double _a)
        {
            if (_a < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}

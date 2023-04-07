using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Mylib
{
    public abstract class Shape
    {
        protected void ValidateArea(double value)
        {
            if(value < 0)
            {
                throw new ArgumentException(nameof(value));
            }
        }

        protected void ValidatePerimeter(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value));
            }
        }
    }
}

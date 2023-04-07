using Figures.Mylib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeworkTests.ShapesTests
{
    public class SquareTest
    {
        [Test]
        public void Square_NegativeSides_Exeption()
        {
            //Act & Assert
            Assert.Throws<ArgumentException>(() => new Square(-5));
        }

        [Test]
        public void Square_CalculatePerimeter_NoExeption()
        {
            //Arrange

            Square square = new Square(5);
            double a = 5;
            double perimeter = 4 * a;

            //Act & Assert
            Assert.DoesNotThrow(() => square.CalculatePerimeter());
        }

        [Test]
        public void Square_CalculateArea_NoExeption()
        {
            //Arrange

            Square square = new Square(5);
            double a = 5;
            double area = a * a;
            //Act
            double squareArea = square.CalculateArea();
            //Assert
            Assert.AreEqual(area, squareArea);
        }
    }
}

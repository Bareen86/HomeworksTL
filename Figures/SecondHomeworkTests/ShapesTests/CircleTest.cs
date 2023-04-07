using Figures.Mylib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeworkTests.ShapesTests
{
    public class CircleTest
    {
        [Test]
        public void Circle_NegativeSides_Exeption()
        {
            //Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Test]
        public void Circle_CalculatePerimeter_NoExeption()
        {
            //Arrange

            Circle circle = new Circle(5);
            double radius = 5;
            double perimeter = 2 * 3.14 * radius;

            //Act & Assert

            Assert.DoesNotThrow(() => circle.CalculatePerimeter());
        }

        [Test]
        public void Circle_CalculateArea_NoExeption()
        {
            //Arrange

            Circle circle = new Circle(5);
            double radius = 5;
            double area = 3.14 * radius * radius;

            // Act

            double circleArea = circle.CalculateArea();

            // Assert

            Assert.AreEqual(area, circleArea);
        }
    }
}

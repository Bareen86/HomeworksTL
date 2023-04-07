using Figures.Mylib;
using System.Reflection;

namespace SecondHomeworkTests.ShapesTests
{
    public class Tests
    {
        [Test]
        public void Triangle_NegativeSides_Exeption()
        {
            //Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));
        }

        [Test]
        public void Triangle_CalculatePerimeter_NoExeption()
        {
            //Arrange

            Triangle triangle = new Triangle(3, 4, 5);

            //Act & Assert
            Assert.DoesNotThrow(() => triangle.CalculatePerimeter());
        }


        [Test]
        public void Triangle_CalculateArea_NoExeption()
        {
            //Arrange

            Triangle triangle = new Triangle(3, 4, 5);

            //Act & Assert
            Assert.DoesNotThrow(() => triangle.CalculateArea());
        }

        [Test]
        public void Triangle_CalculatePerimeter_CorrectAnswer()
        {
            //Arrange

            Triangle triangle = new Triangle(3, 4, 5);
            double perimeter = 3 + 4 + 5;
            //Act
            double trianglePerimeter = triangle.CalculatePerimeter();
            //Assert

            Assert.AreEqual(perimeter, trianglePerimeter);
        }

        [Test]
        public void Triangle_CalculateArea_CorrectAnswer()
        {
            //Arrange

            Triangle triangle = new Triangle(3, 4, 5);
            double perimeter = 3 + 4 + 5;
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - 3) * (halfPerimeter - 4) * (halfPerimeter - 5));
            //Act
            double triangleArea = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(area, triangleArea);
        }
    }
}
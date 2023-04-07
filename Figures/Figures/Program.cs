using Figures.Mylib;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 6);
        double trianglePerimeter = triangle.CalculatePerimeter();
        double triangleArea = triangle.CalculateArea();
        Console.WriteLine($"Triangle perimeter: {trianglePerimeter}sm and Triangle area: {triangleArea}sm^2");

        Circle circle = new Circle(4);
        double circlePerimeter = circle.CalculatePerimeter();
        double circleArea = circle.CalculateArea();
        Console.WriteLine($"Circle perimeter: {circlePerimeter}sm and Circle area: {circleArea}sm^2");

        Square square = new Square(5);
        double squarePerimeter = square.CalculatePerimeter();
        double squareArea = square.CalculateArea();
        Console.WriteLine($"Square perimeter: {squarePerimeter}sm and Square area: {squareArea}sm^2");
    }
}

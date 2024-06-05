using ShapeLibrary.Models.Enums;
using ShapeLibrary.Models.Factory;
using ShapeLibrary.Models.Shapes;

namespace ExternalClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = ShapeFactory.CreateShape(ShapeType.Circle, 5.0);
            var triangleArea = ShapeFactory.CreateShape(ShapeType.Triangle, 3.0, 4.0, 5.0);

            var circleArea = circle.GetArea();
            var triangleAreaa = triangleArea.GetArea();


            Console.WriteLine(circleArea);
            Console.WriteLine(triangleAreaa);

        }
    }
}
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Models.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive and non-zero");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

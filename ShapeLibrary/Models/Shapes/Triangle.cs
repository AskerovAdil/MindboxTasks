using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Models.Shapes
{
    public class Triangle : ITriangle
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Error: Sides must be positive and non-zero");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Error: Sides do not form a valid triangle");

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            double semiPerimeter = (_a + _b + _c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
            return area;
        }

        public bool IsRightAngled()
        {
            bool isRightAngled = _a == Math.Sqrt(Math.Pow(_b, 2) + Math.Pow(_c, 2))
             || _b == Math.Sqrt(Math.Pow(_a, 2) + Math.Pow(_c, 2))
             || _c == Math.Sqrt(Math.Pow(_a, 2) + Math.Pow(_b, 2));
            return isRightAngled;
        }

    }
}

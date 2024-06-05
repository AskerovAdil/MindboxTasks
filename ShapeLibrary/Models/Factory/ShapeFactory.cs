using ShapeLibrary.Interfaces;
using ShapeLibrary.Models.Enums;
using ShapeLibrary.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Models.Factory
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType type, params double[] args)
        {
            return type switch
            {
                ShapeType.Circle => new Circle(args[0]),
                ShapeType.Triangle => new Triangle(args[0], args[1], args[2]),
                _ => throw new ArgumentException($"Unsupported shape type: {type}"),
            };
        }
    }
}

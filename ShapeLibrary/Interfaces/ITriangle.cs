using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Interfaces
{
    public interface ITriangle : IShape
    {
        bool IsRightAngled();
    }
}

using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface ILineSegment
    {
        Vect3 Start { get; }
        Vect3 End { get; }
    }
}
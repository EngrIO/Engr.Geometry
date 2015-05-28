using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface ITriangle:IPolygon
    {
        Point Point1 { get; }
        Point Point2 { get; }
        Point Point3 { get; }
        Vect3f Normal { get; }
    }
}

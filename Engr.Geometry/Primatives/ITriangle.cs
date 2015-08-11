using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface ITriangle:IPolygon
    {
        Vect3 Point1 { get; }
        Vect3 Point2 { get; }
        Vect3 Point3 { get; }
        Vect3 Normal { get; }
    }
}

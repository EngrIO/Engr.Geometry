using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface ITriangle:IPolygon
    {
        IVertex V1 { get; }
        IVertex V2 { get; }
        IVertex V3 { get; }
        Vect3 Normal { get; }
    }
}

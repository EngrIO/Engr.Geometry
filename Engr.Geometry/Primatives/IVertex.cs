using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface IVertex
    {
        Vect3f Position { get; }
        Vect3f Normal { get;}
    }
}
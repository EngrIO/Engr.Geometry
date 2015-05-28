using Engr.Maths.Vectors;

namespace Engr.Geometry.Datums
{
    public interface IPlane
    {
        Vect3f Normal { get; }
        float Constant { get; }
    }
}
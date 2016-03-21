using Engr.Maths.Vectors;

namespace Engr.Geometry.Datums
{
    public interface IPlane
    {
        Vect3 Normal { get; }
        double Constant { get; }
        IPlane Flipped();
    }
}
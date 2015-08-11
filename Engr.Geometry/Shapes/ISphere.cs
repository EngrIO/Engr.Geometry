using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{
    public interface ISphere
    {
        Vect3 Center { get; }
        float Radius { get; }
    }
}
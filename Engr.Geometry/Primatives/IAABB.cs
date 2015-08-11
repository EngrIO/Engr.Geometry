using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface IAABB
    {
        Vect3 Min { get; }
        Vect3 Max { get; }

        Vect3 Center { get; }
        Vect3 HalfSize { get; }

    }
}
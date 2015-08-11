using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{
    public class Sphere : ISphere
    {
        public Vect3 Center { get; private set; }
        public float Radius { get; private set; }

        public Sphere(Vect3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}
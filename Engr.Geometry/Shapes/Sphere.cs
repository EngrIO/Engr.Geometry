using Engr.Geometry.Datums;

namespace Engr.Geometry.Shapes
{
    public class Sphere : ISphere
    {
        public Point Center { get; private set; }
        public float Radius { get; private set; }

        public Sphere(Point center, float radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}
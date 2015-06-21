using System;
using Engr.Geometry.Shapes;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Datums
{
    public class Plane : IPlane
    {
        public Vect3f Normal { get; private set; }
        public float Constant { get; private set; }

        public Plane(Vect3f normal, float constant)
        {
            Normal = normal;
            Constant = constant;
        }

        public static Plane FromPoints(Vect3f a, Vect3f b, Vect3f c)
        {
            var n = (b - a).CrossProduct(c - a).Normalize();
            return new Plane(n, n.DotProduct(a));
        }


        public static Plane FromPoints(params Vect3f [] points)
        {
            if(points.Length < 3) throw new ArgumentException();
            return FromPoints(points[0], points[1], points[2]);
        }

        public static Plane FromEquation(float a, float b, float c, float d)
        {
            var l = new Vect3f(a, b, c).Length;
            return new Plane(new Vect3f(a/l,b/l,c/l).Normalize(), d/l);
        }

        public float DistanceTo(Point p)
        {
            return Normal.DotProduct(p) + Constant;
        }

        public float DistanceTo(Sphere s)
        {
            return DistanceTo(s.Center) - s.Radius;
        }

        public Plane Invert()
        {
            return new Plane(-Normal, -Constant);
        }
        public Plane Normalize()
        {
            return new Plane(Normal.Normalize(), Constant / Normal.Length);
        }
    }
}

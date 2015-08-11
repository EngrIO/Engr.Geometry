using System;
using Engr.Geometry.Shapes;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Datums
{
    public class Plane : IPlane
    {
        public Vect3 Normal { get; private set; }
        public double Constant { get; private set; }

        public Plane(Vect3 normal, double constant)
        {
            Normal = normal;
            Constant = constant;
        }

        public static Plane FromPoints(Vect3 a, Vect3 b, Vect3 c)
        {
            var n = (b - a).CrossProduct(c - a).Normalize();
            return new Plane(n, n.DotProduct(a));
        }
        
        public static Plane FromPoints(params Vect3 [] points)
        {
            if(points.Length < 3) throw new ArgumentException();
            return FromPoints(points[0], points[1], points[2]);
        }

        public static Plane FromEquation(double a, double b, double c, double d)
        {
            var l = new Vect3(a, b, c).Length;
            return new Plane(new Vect3(a/l,b/l,c/l).Normalize(), d/l);
        }

        public double DistanceTo(Vect3 p)
        {
            return Normal.DotProduct(p) + Constant;
        }

        public double DistanceTo(Sphere s)
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

using System;
using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Intersections
{
    public static class TriangleInteresctions
    {
        public static bool Intersects(this ITriangle tri, IAABB aabb)
        {
            var v0 = tri.Point1 - aabb.Center;
            var v1 = tri.Point2 - aabb.Center;
            var v2 = tri.Point3 - aabb.Center;

            var f0 = v1 - v0;
            var f1 = v2 - v1;
            var f2 = v0 - v2;

            var axes = new[]
            {
                new Vect3(0, -f0.Z, f0.Y),
                new Vect3(0, -f1.Z, f1.Y), 
                new Vect3(0, -f2.Z, f2.Y),
                new Vect3(f0.Z, 0, -f0.X), 
                new Vect3(f1.Z, 0, -f1.X),
                new Vect3(f2.Z, 0, -f2.X),
                new Vect3(-f0.Y, f0.X, 0), 
                new Vect3(-f1.Y, f1.X, 0), 
                new Vect3(-f2.Y, f2.X, 0)
            };

            foreach (var axis in axes)
            {
                var p0 = v0.DotProduct(axis);
                var p1 = v1.DotProduct(axis);
                var p2 = v2.DotProduct(axis);
                var r = aabb.HalfSize.X * Math.Abs(axis.X) + aabb.HalfSize.Y * Math.Abs(axis.Y) + aabb.HalfSize.Z * Math.Abs(axis.Z);
                if (Math.Max(-MathsHelper.Max(p0, p1, p2), MathsHelper.Min(p0, p1, p2)) > r) return false;
            }

            if (MathsHelper.Max(v0.X, v1.X, v2.X) < -aabb.HalfSize.X || MathsHelper.Min(v0.X, v1.X, v2.X) > aabb.HalfSize.X) return false;
            if (MathsHelper.Max(v0.Y, v1.Y, v2.Y) < -aabb.HalfSize.Y || MathsHelper.Min(v0.Y, v1.Y, v2.Y) > aabb.HalfSize.Y) return false;
            if (MathsHelper.Max(v0.Z, v1.Z, v2.Z) < -aabb.HalfSize.Z || MathsHelper.Min(v0.Z, v1.Z, v2.Z) > aabb.HalfSize.Z) return false;
            var normal = f0.CrossProduct(f1);
            var p = new Plane(normal, normal.DotProduct(v0));
            return p.Intersects(aabb);
        }




        public static void Barycentric(this ITriangle tri, Vect3 p, out double u, out double v, out double w)
        {
            var v0 = tri.Point2 - tri.Point1;
            var v1 = tri.Point3 - tri.Point1;
            var v2 = p - tri.Point1;
            var d00 = v0.DotProduct(v0);
            var d01 = v0.DotProduct(v1);
            var d11 = v1.DotProduct(v1);
            var d20 = v2.DotProduct(v0);
            var d21 = v2.DotProduct(v1);
            var denom = d00 * d11 - d01 * d01;
            v = (d11 * d20 - d01 * d21) / denom;
            w = (d00 * d21 - d01 * d20) / denom;
            u = 1.0f - v - w;
        }
    }

    public enum IntersectResult { }
}
using System;
using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;

namespace Engr.Geometry.Intersections
{
    public static class PlaneInteresctions
    {
        public static bool Intersects(this IPlane p, AABB aabb)
        {
            var r = aabb.HalfSize.X * Math.Abs(p.Normal.X) + aabb.HalfSize.Y * Math.Abs(p.Normal.Y) + aabb.HalfSize.Z * Math.Abs(p.Normal.Z);
            var s = p.Normal.DotProduct(aabb.Center) - p.Constant;
            return Math.Abs(s) <= r;
        }
    }
}
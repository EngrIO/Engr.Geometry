using System;
using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Intersections
{
    public static class Vect3Intersections
    {


        public static bool On(this Vect3 p, IPlane plane, double epslion = 1E-07)
        {

            return true;
        }

        public static bool On(this Vect3 p, ITriangle triangle, double epslion = 1E-07)
        {
            double u, v, w;
            triangle.Barycentric(p, out u, out v, out w);
            return v >= 0f && w >= 0f && (v + w) <= 1f;
        }

        public static bool On(this Vect3 p, IAABB aabb, double epslion = 1E-07)
        {
            var distance = aabb.Center - p;
            return Math.Abs(distance.X).NearlyEquals(aabb.HalfSize.X, epslion)
                && Math.Abs(distance.Y).NearlyEquals(aabb.HalfSize.Y, epslion)
                && Math.Abs(distance.Z).NearlyEquals(aabb.HalfSize.Z, epslion);
        }

        public static bool In(this Vect3 p, IAABB aabb, double epslion = 1E-07)
        {
            var distance = aabb.Center - p;
            return Math.Abs(distance.X).NearlyLessThanOrEquals(aabb.HalfSize.X, epslion)
                && Math.Abs(distance.Y).NearlyLessThanOrEquals(aabb.HalfSize.Y, epslion)
                && Math.Abs(distance.Z).NearlyLessThanOrEquals(aabb.HalfSize.Z, epslion);
        }


        //public static bool In(this Vect3 p, IAABB aabb, double epslion = 0.0001)
        //{
        //    var distance = aabb.Center - p;

        //    MathsExtensions.NearlyEquals()

        //    return Math.Abs(distance.X).NearlyLessThanOrEquals(box.HalfSize.X) && Math.Abs(distance.Y).NearlyLessThanOrEquals(box.HalfSize.Y) && Math.Abs(distance.Z).NearlyLessThanOrEquals(box.HalfSize.Z);

        //}

    }
}
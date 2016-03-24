using System;
using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{

    public class Triangle : BasePolygon,ITriangle
    {
        public Vect3 Point1 { get; private set; }
        public Vect3 Point2 { get; private set; }
        public Vect3 Point3 { get; private set; }
        public Vect3 Normal { get; private set; }

        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3, Vect3 normal)
            : base(new[] { point1, point2, point3 }, new[] { new LineSegment(point1, point2), new LineSegment(point2, point3), new LineSegment(point3, point1)})
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Normal = normal;
        }

        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3)
            : this(point1, point2, point3, CalculateNormal(point1, point2, point3))
        {

        }

        private static Vect3 CalculateNormal(Vect3 point1, Vect3 point2, Vect3 point3)
        {
            var u = point2 - point1;
            var v = point3 - point1;
            return u.CrossProduct(v);

        }

        public override IPolygon Flipped()
        {
            return new Triangle(Point3, Point2, Point1);
        }

        public Vect3 Centroid()
        {
            return (Point1 + Point2 + Point3) / 3.0;
        }
        public Vect3 Circumcenter()
        {
            return Circle.FromPoints(Point1, Point2, Point3).Center;
        }

    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class Triangle : BasePolygon,ITriangle
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Vect3f Normal { get; private set; }


        public Triangle(Point point1, Point point2, Point point3, Vect3f normal) :
            base(new[] { point1, point2, point3 }, new[] { new LineSegment(point1, point2), new LineSegment(point2, point3), new LineSegment(point3, point1) })
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Normal = normal;
        }
    }
}
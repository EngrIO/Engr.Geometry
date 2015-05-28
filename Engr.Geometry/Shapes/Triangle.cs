using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{
    public class Triangle : BasePolygon,ITriangle
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Vect3f Normal { get; private set; }

        public Triangle(Point point1, Point point2, Point point3, Vect3f normal) 
            : base(new[] { point1, point2, point3 }, new[] { new LineSegment(point1, point2), new LineSegment(point2, point3), new LineSegment(point3, point1) })
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Normal = normal;
        }

        public Triangle(Point point1, Point point2, Point point3)
            : this(point1, point2, point3, CalculateNormal(point1, point2, point3))
        {
            
        }
        

        public static Plane FromPoints(Vect3f a, Vect3f b, Vect3f c)
        {
            var n = (b - a).CrossProduct(c - a).Normalized();
            return new Plane(n, n.DotProduct(a));
        }

        private static Vect3f CalculateNormal(Vect3f point1, Vect3f point2, Vect3f point3)
        {
            var u = point2 - point1;
            var v = point3 - point1;
            return u.CrossProduct(v);

        }
    }
}
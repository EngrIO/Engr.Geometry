using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{

    public class Triangle<T> : BasePolygon<T>,ITriangle
    {
        public Vect3 Point1 { get; private set; }
        public Vect3 Point2 { get; private set; }
        public Vect3 Point3 { get; private set; }
        public Vect3 Normal { get; private set; }

        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3, Vect3 normal, T data)
            : base(new[] { point1, point2, point3 }, new[] { new LineSegment(point1, point2), new LineSegment(point2, point3), new LineSegment(point3, point1)}, data)
        {
            Point1 = point1;
            Normal = normal;
            Point3 = point3;
            Point2 = point2;
        }

        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3, T data)
            : this(point1, point2, point3, CalculateNormal(point1, point2, point3), data)
        {

        }

        private static Vect3 CalculateNormal(Vect3 point1, Vect3 point2, Vect3 point3)
        {
            var u = point2 - point1;
            var v = point3 - point1;
            return u.CrossProduct(v);

        }


    }

    public class Triangle : Triangle<object> {
        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3, Vect3 normal, object data = null) 
            : base(point1, point2, point3, normal, data)
        {
        }

        public Triangle(Vect3 point1, Vect3 point2, Vect3 point3, object data = null) 
            : base(point1, point2, point3, data)
        {
        }
    }

}
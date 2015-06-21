﻿using Engr.Geometry.Datums;
using Engr.Geometry.Primatives;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Shapes
{

    public class Triangle<T> : BasePolygon<T>
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Vect3f Normal { get; private set; }

        public Triangle(Point point1, Point point2, Point point3, Vect3f normal, T data)
            : base(new[] { point1, point2, point3 }, new[] { new LineSegment(point1, point2), new LineSegment(point2, point3), new LineSegment(point3, point1)}, data)
        {
            Point1 = point1;
            Normal = normal;
            Point3 = point3;
            Point2 = point2;
        }

        public Triangle(Point point1, Point point2, Point point3 , T data)
            : this(point1, point2, point3, CalculateNormal(point1, point2, point3), data)
        {

        }

        private static Vect3f CalculateNormal(Vect3f point1, Vect3f point2, Vect3f point3)
        {
            var u = point2 - point1;
            var v = point3 - point1;
            return u.CrossProduct(v);

        }


    }

    public class Triangle : Triangle<object> {
        public Triangle(Point point1, Point point2, Point point3, Vect3f normal, object data = null) 
            : base(point1, point2, point3, normal, data)
        {
        }

        public Triangle(Point point1, Point point2, Point point3, object data = null) 
            : base(point1, point2, point3, data)
        {
        }
    }

}
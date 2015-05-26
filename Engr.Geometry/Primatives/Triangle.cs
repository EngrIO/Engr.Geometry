using System.Collections.Generic;
using System.Collections.ObjectModel;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class Triangle : BasePolygon,ITriangle
    {
        public IVertex V1 { get; private set; }
        public IVertex V2 { get; private set; }
        public IVertex V3 { get; private set; }
        public Vect3 Normal { get; private set; }


        public Triangle(IVertex v1, IVertex v2, IVertex v3, Vect3 normal):
            base(new[] { v1, v2, v3 }, new[] { new LineSegment(v1, v2), new LineSegment(v2, v3), new LineSegment(v3, v1) })
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            Normal = normal;
        }
    }
}
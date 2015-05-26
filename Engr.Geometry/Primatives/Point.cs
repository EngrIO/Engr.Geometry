using System.Collections.Generic;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class Point : Vect3f
    {
        public Point(float x, float y, float z) : base(x, y, z)
        {

        }

        public Point(IList<float> a) : base(a)
        {

        }
        public Point(Vect3f v)
            : base(v.X, v.Y, v.Z)
        {

        }
    }
}
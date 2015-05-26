using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Datums
{
    public class Plane
    {
        public Vect3f Normal { get; private set; }
        public float W { get; private set; }
        public Plane(Vect3f normal, float w)
        {
            Normal = normal;
            W = w;
        }

        public Plane Flip()
        {
            return new Plane(-Normal,-W);
        }

        public static Plane FromPoints(Vect3f a, Vect3f b, Vect3f c)
        {
            var n = (b - a).CrossProduct(c - a).Normalized();
            return new Plane(n, n.DotProduct(a));
        }
    }
}

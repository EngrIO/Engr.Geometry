using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class AABB : IAABB
    {
        public Vect3 Min
        {
            get
            {
                return Center - HalfSize;
            }
        }

        public Vect3 Max
        {
            get
            {
                return Center + HalfSize;
            }
        }

        public Vect3 Center { get; private set; }
        public Vect3 HalfSize { get; private set; }

        public AABB(Vect3 center, double halfSize)
        {
            Center = center;
            HalfSize = new Vect3(halfSize, halfSize, halfSize);
        }

        public AABB(Vect3 center, Vect3 halfSize)
        {
            Center = center;
            HalfSize = halfSize;
        }
    }
}

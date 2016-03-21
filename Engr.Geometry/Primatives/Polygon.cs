using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class Polygon : BasePolygon
    {
        protected Polygon(IEnumerable<Vect3> points) : base(points.ToList())
        {

        }
        public override IPolygon Flipped()
        {
            return new Polygon(Points.Reverse());
        }
    }
}

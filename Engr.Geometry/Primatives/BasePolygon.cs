using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{

    public abstract class BasePolygon : IPolygon
    {
        public IReadOnlyList<Vect3> Points { get; protected set; }
        public IReadOnlyList<ILineSegment> Edges { get; protected set; }

        public Plane Plane
        {
            get
            {
                return Plane.FromPoints(Points[0], Points[1], Points[2]);
            }
        }

        protected BasePolygon(IList<Vect3> points, IList<ILineSegment> edges)
        {

            Points = new ReadOnlyCollection<Vect3>(points);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }

        protected BasePolygon(IList<Vect3> points)
        {
            Points = new ReadOnlyCollection<Vect3>(points);

            var edges = new List<ILineSegment>(points.Zip(points.Skip(1), (a, b) => new LineSegment(a, b)))
            {
                new LineSegment(points.Last(), points.First())
            };
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }
}
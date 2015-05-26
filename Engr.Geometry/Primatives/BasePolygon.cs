using System.Collections.Generic;
using System.Collections.ObjectModel;
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{
    public abstract class BasePolygon : IPolygon
    {

        public IReadOnlyList<Point> Points { get; protected set; }
        public IReadOnlyList<ILineSegment> Edges { get; protected set; }
        public Plane Plane
        {
            get
            {
                return Plane.FromPoints(Points[0], Points[1], Points[2]);
            }
        }

        protected BasePolygon(IList<Point> points, IList<ILineSegment> edges)
        {
            Points = new ReadOnlyCollection<Point>(points);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{
    public abstract class BasePolygon : IPolygon
    {

        public IReadOnlyList<IVertex> Vertices { get; protected set; }
        public IReadOnlyList<ILineSegment> Edges { get; protected set; }
        public Plane Plane
        {
            get
            {
                return Plane.FromPoints(Vertices[0].Position, Vertices[1].Position, Vertices[2].Position);
            }
        }

        protected BasePolygon(IList<IVertex> vertices, IList<ILineSegment> edges)
        {
            Vertices = new ReadOnlyCollection<IVertex>(vertices);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }
}
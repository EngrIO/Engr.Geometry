using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Engr.Geometry.Primatives
{
    public abstract class BasePolygon : IPolygon
    {

        public IReadOnlyList<IVertex> Vertices { get; protected set; }
        public IReadOnlyList<ILineSegment> Edges { get; protected set; }

        protected BasePolygon(IList<IVertex> vertices, IList<ILineSegment> edges)
        {
            Vertices = new ReadOnlyCollection<IVertex>(vertices);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }
}
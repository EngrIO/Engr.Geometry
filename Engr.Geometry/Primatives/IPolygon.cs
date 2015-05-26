using System.Collections.Generic;

namespace Engr.Geometry.Primatives
{
    public interface IPolygon
    {
        IReadOnlyList<IVertex> Vertices { get; }
        IReadOnlyList<ILineSegment> Edges { get; }
    }
}
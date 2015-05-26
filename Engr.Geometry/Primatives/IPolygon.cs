using System.Collections.Generic;
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{
    public interface IPolygon
    {
        IReadOnlyList<IVertex> Vertices { get; }
        IReadOnlyList<ILineSegment> Edges { get; }

        Plane Plane { get; }
    }
}
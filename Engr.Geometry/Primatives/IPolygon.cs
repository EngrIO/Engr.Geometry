using System.Collections.Generic;
using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public interface IPolygon
    {
        IReadOnlyList<Vect3> Points { get; }
        IReadOnlyList<ILineSegment> Edges { get; }
        Plane Plane { get; }
        IPolygon Flipped();
    }
}
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{
    public interface ILineSegment
    {
        Point Start { get; }
        Point End { get; }
    }
}
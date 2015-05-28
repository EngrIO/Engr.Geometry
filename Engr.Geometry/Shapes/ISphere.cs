using Engr.Geometry.Datums;

namespace Engr.Geometry.Shapes
{
    public interface ISphere
    {
        Point Center { get; }
        float Radius { get; }
    }
}
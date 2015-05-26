namespace Engr.Geometry.Primatives
{
    public interface ILineSegment
    {
        IVertex Start { get; }
        IVertex End { get; }
    }
}
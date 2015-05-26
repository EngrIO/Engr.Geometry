using System;

namespace Engr.Geometry.Primatives
{
    public class LineSegment : ILineSegment
    {
        public IVertex Start { get; private set; }
        public IVertex End { get; private set; }

        public Func<float, IVertex> Equation
        {
            get
            {
                return d => new Vertex(Start.Position.Lerp(End.Position, d),Start.Normal.Lerp(End.Normal, d));
            }
        }

        public LineSegment(IVertex start, IVertex end)
        {
            Start = start;
            End = end;
        }
    }
}
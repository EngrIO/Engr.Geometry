using System;
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{
    public class LineSegment : ILineSegment
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }

        public Func<float, Point> Equation
        {
            get
            {
                return d => new Point(Start.Lerp(End, d));
            }
        }

        public LineSegment(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}
using System;
using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{
    public class LineSegment : ILineSegment
    {
        public Vect3 Start { get; private set; }
        public Vect3 End { get; private set; }

        public Func<float, Vect3> Equation
        {
            get
            {
                return d => Start.Lerp(End, d);
            }
        }

        public LineSegment(Vect3 start, Vect3 end)
        {
            Start = start;
            End = end;
        }
    }
}
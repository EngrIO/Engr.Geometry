﻿using Engr.Maths.Vectors;

namespace Engr.Geometry
{
    public class Vertex
    {
        public Vect3f Position { get; private set; }
        public Vect3f Normal { get; private set; }

        public Vertex(Vect3f position, Vect3f normal)
        {
            Position = position;
            Normal = normal;
        }

        public Vertex Invert()
        {
            return new Vertex(Position, -Normal);
        }
    }
}

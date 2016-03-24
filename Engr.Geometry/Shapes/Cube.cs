using Engr.Geometry.Primatives;
using Engr.Maths.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engr.Geometry.Shapes
{
    public class Cube : ICube
    {
        public Vect3 Center { get; private set; }
        public Vect3 Size { get; private set; }

        public Cube(Vect3 center, double size)
        {
            Center = center;
            Size = new Vect3(size, size, size);
        }
        public IEnumerable<IPolygon> ToPolygons()
        {
            throw new NotImplementedException();
        }
        //public IEnumerable<IPolygon> ToPolygons()
        //{
        //    var r = Size / 2.0;
        //    var a = new int[][]
        //    {
        //        new [] {0, 4, 6, 2},
        //        new [] {1, 3, 7, 5},
        //        new [] {0, 1, 5, 4},
        //        new [] {2, 6, 7, 3},
        //        new [] {0, 2, 3, 1},
        //        new [] {4, 5, 7, 6}

        //    };
        //    return a.Select(a =>
        //    {

        //    return new Vect3(Center.X + r.X * (2 * !!(a & 1) - 1),Center.Y + r[1] * (2 * !!(a & 2) - 1), Center.Z + r[2] * (2 * !!(a & 4) - 1));
        //    })
        //}
    }

    public interface ICube
    {
        Vect3 Center { get; }
        Vect3 Size { get; }

        IEnumerable<IPolygon> ToPolygons();
    }
}

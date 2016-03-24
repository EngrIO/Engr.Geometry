using Engr.Maths.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engr.Geometry.Shapes
{
    public class Circle : ICircle
    {
        public Vect3 Axis { get; private set; }

        public Vect3 Center { get; private set; }

        public double Radius { get; private set; }

        public Circle(Vect3 center, double radius, Vect3 axis)
        {
            Center = center;
            Radius = radius;
            Axis = axis;
        }

        //TODO
        public static ICircle FromPoints(Vect3 a, Vect3 b, Vect3 c)
        {
            var t = b - a;
            var u = c- a;
            var v = c - b;

            var w = t.CrossProduct(u);
            var wsl = w.LengthSquared;

            double iwsl2 = 1.0 / (2.0 * wsl);

            var center = a + (u * t.DotProduct(t) * (u.DotProduct(v)) - t * u.DotProduct(u) * (t.DotProduct(v))) * iwsl2;
            var radius = Math.Sqrt(t.DotProduct(t) * u.DotProduct(u) * (v.DotProduct(v)) * iwsl2 * 0.5);
            var axis = w / Math.Sqrt(wsl);

            return new Circle(center, radius, axis);
        }
    }

    public interface ICircle
    {
        Vect3 Center { get; }
        Vect3 Axis { get; }
        double Radius { get; }
    }
}

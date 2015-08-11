using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engr.Geometry
{
    public static class Extensions
    {
        public static bool NearlyEquals(this double x, double y, double epsilon = 0.0000001)
        {
            return Math.Abs(x - y) <= Math.Abs(x * epsilon);
        }

        public static bool NearlyEquals(this float x, float y, float epsilon = 0.0000001f)
        {
            return Math.Abs(x - y) <= Math.Abs(x * epsilon);
        }
    }
}

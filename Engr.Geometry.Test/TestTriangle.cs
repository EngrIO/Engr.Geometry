using Engr.Geometry.Datums;
using Engr.Geometry.Shapes;
using Engr.Maths.Vectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Geometry.Test
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void Constructor()
        {
            var tri = new Triangle(new Vect3(1, 2, 3), new Vect3(4, 5, 6), new Vect3(7, 8, 9));
        }
    }
}
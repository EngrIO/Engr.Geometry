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

        [TestMethod]
        public void Centroid()
        {
            var val = new Triangle(new Vect3(1, 2, 3), new Vect3(4, 5, 6), new Vect3(7, 2, 3)).Centroid();
            Assert.IsTrue(val.X.NearlyEquals(4.0));
            Assert.IsTrue(val.Y.NearlyEquals(3.0));
            Assert.IsTrue(val.Z.NearlyEquals(4.0));
        }

        [TestMethod]
        public void Circumcentre()
        {
            var val = new Triangle(new Vect3(1, 2, 0), new Vect3(4, 5, 0), new Vect3(7, 2, 0)).Circumcenter();
            Assert.IsTrue(val.X.NearlyEquals(4.0));
            Assert.IsTrue(val.Y.NearlyEquals(2.0));
            Assert.IsTrue(val.Z.NearlyEquals(0.0));
        }
    }
}
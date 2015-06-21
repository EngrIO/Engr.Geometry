using Engr.Geometry.Datums;
using Engr.Geometry.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Geometry.Test
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void Constructor()
        {
            var tri = new Triangle(new Point(1, 2, 3), new Point(4, 5, 6), new Point(7, 8, 9));
            Assert.AreEqual(tri.Data, null);

            var t2 = new Triangle<string>(new Point(1, 2, 3), new Point(4, 5, 6), new Point(7, 8, 9), "test");
            Assert.AreEqual(t2.Data, "test");
        }
    }
}
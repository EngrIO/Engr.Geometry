using Engr.Geometry.Intersections;
using Engr.Geometry.Primatives;
using Engr.Geometry.Shapes;
using Engr.Maths.Vectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Geometry.Test.Intersections
{

    [TestClass]
    public class TriangleIntersectionTests
    {
        [TestMethod]
        public void TestAABB()
        {
            var aabb = new AABB(Vect3.Zero, 0.5);
            var tri1 = new Triangle(new Vect3(0, 0, 0),new Vect3(0, 0.4, 0),new Vect3(0, 0, 0.4));
            var tri2 = new Triangle(new Vect3(2, 0, 0), new Vect3(2, 0.4, 0), new Vect3(2, 0, 0.4));
            var tri3 = new Triangle(new Vect3(0, -1, -1), new Vect3(0, 1, 0), new Vect3(0, 0, 1));
            var tri4 = new Triangle(new Vect3(0, -1, -1), new Vect3(1, 1, 0), new Vect3(1, 0, 1));
            Assert.IsTrue(tri1.Intersects(aabb));
            Assert.IsFalse(tri2.Intersects(aabb));
            Assert.IsTrue(tri3.Intersects(aabb));
            Assert.IsTrue(tri4.Intersects(aabb));


        }
    }

    [TestClass]
    public class Vect3IntersectionTests
    {
        [TestMethod]
        public void TestTriangle()
        {
            var triangle = new Triangle(new Vect3(289, 40, 0), new Vect3(113, 30, 0), new Vect3(403, 207, 0));
            Assert.IsTrue(new Vect3(287, 102, 0).On(triangle));
            Assert.IsFalse(new Vect3(259, 140, 0).On(triangle));


            



            //var plane = new Plane(Vect3f.UnitZ, 0.0f);
            //Assert.AreEqual(true, new Point(0,0,0).On(plane));
            //Assert.AreEqual(false, new Point(1,0,0).On(plane));

        }

        [TestMethod]
        public void TestAABB()
        {

            var aabb = new AABB(Vect3.Zero, 0.5);
            Assert.IsTrue(new Vect3(0.5, 0.5, 0.5).On(aabb));
            Assert.IsFalse(new Vect3(0.4, 0.5, 0.5).On(aabb));
            Assert.IsFalse(new Vect3(0.5, 0.4, 0.5).On(aabb));
            Assert.IsFalse(new Vect3(0.5, 0.5, 0.4).On(aabb));

            Assert.IsTrue(new Vect3(0, 0, 0).In(aabb));
            Assert.IsTrue(new Vect3(0.4, 0, 0).In(aabb));
            Assert.IsTrue(new Vect3(0, 0.4, 0).In(aabb));
            Assert.IsTrue(new Vect3(0, 0, 0.4).In(aabb));
            Assert.IsTrue(new Vect3(-0.4, 0, 0).In(aabb));
            Assert.IsTrue(new Vect3(0, -0.4, 0).In(aabb));
            Assert.IsTrue(new Vect3(0, 0, -0.4).In(aabb));


            Assert.IsFalse(new Vect3(0.6, 0, 0).In(aabb));
            Assert.IsFalse(new Vect3(0, 0.6, 0).In(aabb));
            Assert.IsFalse(new Vect3(0, 0, 0.6).In(aabb));
            Assert.IsFalse(new Vect3(-0.6, 0, 0).In(aabb));
            Assert.IsFalse(new Vect3(0, -0.6, 0).In(aabb));
            Assert.IsFalse(new Vect3(0, 0, -0.6).In(aabb));
        }
    }

}

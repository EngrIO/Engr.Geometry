using System;
using Engr.Geometry.Datums;
using Engr.Maths.Vectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Geometry.Test
{
    [TestClass]
    public class TestPlane
    {
        [TestMethod]
        public void Constructor()
        {
            var p1 = new Plane(new Point(1, 2, 3), 0);
            Assert.AreEqual(p1.Normal.X, 1, Constants.Delta);
            Assert.AreEqual(p1.Normal.Y, 2, Constants.Delta);
            Assert.AreEqual(p1.Normal.Z, 3, Constants.Delta);
            Assert.AreEqual(p1.Constant, 0, Constants.Delta);

            var p2 = new Plane(new Point(4, 5, 6), 5);
            Assert.AreEqual(p2.Normal.X, 4, Constants.Delta);
            Assert.AreEqual(p2.Normal.Y, 5, Constants.Delta);
            Assert.AreEqual(p2.Normal.Z, 6, Constants.Delta);
            Assert.AreEqual(p2.Constant, 5, Constants.Delta);

            var p3 = Plane.FromPoints(new Vect3f(1,-2,0), new Vect3f(3,1,4), new Vect3f(0,-1,2));
            var p4 = Plane.FromEquation(2, -8, 5, 18);
            Assert.AreEqual(p3.Normal.X, p4.Normal.X, Constants.Delta);
            Assert.AreEqual(p3.Normal.Y, p4.Normal.Y, Constants.Delta);
            Assert.AreEqual(p3.Normal.Z, p4.Normal.Z, Constants.Delta);
            Assert.AreEqual(p3.Constant, p4.Constant, Constants.Delta);
        }

        [TestMethod]
        public void Normalise()
        {
            var a = new Plane(new Vect3f(2, 0, 0), -2).Normalize();
            Assert.AreEqual(a.DistanceTo(new Point(4, 0, 0)), 3, Constants.Delta);
            Assert.AreEqual(a.DistanceTo(new Point(1, 0, 0)), 0, Constants.Delta);
        }

        [TestMethod]
        public void Invert()
        {
            var a = new Plane(new Vect3f(1, 0, 0), -1).Invert();
            Assert.AreEqual(a.DistanceTo(new Point(4, 0, 0)), -3, Constants.Delta);
            Assert.AreEqual(a.DistanceTo(new Point(1, 0, 0)), 0, Constants.Delta);
        }
    }
}

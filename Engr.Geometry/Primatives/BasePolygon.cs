using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Engr.Geometry.Datums;
using Engr.Maths.Vectors;

namespace Engr.Geometry.Primatives
{

    public abstract class BasePolygon<T> : IPolygon<T>
    {
        public IReadOnlyList<Vect3> Points { get; protected set; }
        public IReadOnlyList<ILineSegment> Edges { get; protected set; }

        public Plane Plane
        {
            get
            {
                return Plane.FromPoints(Points[0], Points[1], Points[2]);
            }
        }

        object IPolygon.Data { get { return Data; }}

        public T Data { get; private set; }

        protected BasePolygon(IList<Vect3> points, IList<ILineSegment> edges, T data)
        {
            Data = data;
            Points = new ReadOnlyCollection<Vect3>(points);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }

        protected BasePolygon(IList<Vect3> points, T data)
        {
            Data = data;
            Points = new ReadOnlyCollection<Vect3>(points);

            var edges = new List<ILineSegment>(points.Zip(points.Skip(1), (a, b) => new LineSegment(a, b)))
            {
                new LineSegment(points.Last(), points.First())
            };
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }


    public class Polygon<T> : BasePolygon<T>
    {
        protected Polygon(IList<Vect3> points, IList<ILineSegment> edges, T data) 
            : base(points,edges,data)
        {
            
        }

        public Polygon(IList<Vect3> points, T data)
            : base(points, data)
        {
            
        }
    }


}
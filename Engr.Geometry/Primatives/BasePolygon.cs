using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Engr.Geometry.Datums;

namespace Engr.Geometry.Primatives
{

    public abstract class BasePolygon<T> : IPolygon<T>
    {
        public IReadOnlyList<Point> Points { get; protected set; }
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

        protected BasePolygon(IList<Point> points, IList<ILineSegment> edges, T data)
        {
            Data = data;
            Points = new ReadOnlyCollection<Point>(points);
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }

        protected BasePolygon(IList<Point> points, T data)
        {
            Data = data;
            Points = new ReadOnlyCollection<Point>(points);

            var edges = new List<ILineSegment>(points.Zip(points.Skip(1), (a, b) => new LineSegment(a, b)))
            {
                new LineSegment(points.Last(), points.First())
            };
            Edges = new ReadOnlyCollection<ILineSegment>(edges);
        }
    }


    public class Polygon<T> : BasePolygon<T>
    {
        protected Polygon(IList<Point> points, IList<ILineSegment> edges, T data) 
            : base(points,edges,data)
        {
            
        }

        public Polygon(IList<Point> points, T data)
            : base(points, data)
        {
            
        }
    }


}
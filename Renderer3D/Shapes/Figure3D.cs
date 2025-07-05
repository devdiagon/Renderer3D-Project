using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D.Shapes
{
    internal abstract class Figure3D
    {
        public List<Point3D> Vertices { get; protected set; } = new List<Point3D>();
        public int[,] Edges { get; protected set; }
        public Point3D Position { get; set; } = new Point3D(0, 0, 10);

        public void Reset()
        {
            Position = new Point3D(0, 0, 10);
        }
    }
}

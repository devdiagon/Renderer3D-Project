using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D.Shapes
{
    internal class Cube : Figure3D
    {
        public Cube()
        {
            float size = 1f;
            Vertices = new List<Point3D>
        {
            new Point3D(-size, -size, -size),
            new Point3D(size, -size, -size),
            new Point3D(size, size, -size),
            new Point3D(-size, size, -size),
            new Point3D(-size, -size, size),
            new Point3D(size, -size, size),
            new Point3D(size, size, size),
            new Point3D(-size, size, size)
        };

            Edges = new int[,]
            {
            { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 0 },
            { 4, 5 }, { 5, 6 }, { 6, 7 }, { 7, 4 },
            { 0, 4 }, { 1, 5 }, { 2, 6 }, { 3, 7 }
            };
        }
    }
}

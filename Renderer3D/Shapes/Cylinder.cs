using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Renderer3D.Shapes
{
    internal class Cylinder : Figure3D
    {
        public Cylinder(int segments = 24, float height = 2f, float radius = 1f)
        {
            Vertices = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            // Base inferior
            for (int i = 0; i < segments; i++)
            {
                float angle = (float)(2 * Math.PI * i / segments);
                float x = radius * (float)Math.Cos(angle);
                float z = radius * (float)Math.Sin(angle);
                Vertices.Add(new Point3D(x, -height / 2, z));
            }

            // Base superior
            for (int i = 0; i < segments; i++)
            {
                float angle = (float)(2 * Math.PI * i / segments);
                float x = radius * (float)Math.Cos(angle);
                float z = radius * (float)Math.Sin(angle);
                Vertices.Add(new Point3D(x, height / 2, z));
            }

            // Aristas
            for (int i = 0; i < segments; i++)
            {
                int next = (i + 1) % segments;
                edgeList.Add((i, next)); // base inferior
                edgeList.Add((i + segments, next + segments)); // base superior
                edgeList.Add((i, i + segments)); // lateral
            }

            Edges = new int[edgeList.Count, 2];
            for (int i = 0; i < edgeList.Count; i++)
            {
                Edges[i, 0] = edgeList[i].Item1;
                Edges[i, 1] = edgeList[i].Item2;
            }
        }
    }
}

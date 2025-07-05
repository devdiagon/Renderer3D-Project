using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D.Shapes
{
    internal class Sphere : Figure3D
    {
        public Sphere(int lat = 12, int lon = 12, float radius = 1f)
        {
            Vertices = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            for (int i = 0; i <= lat; i++)
            {
                float theta = (float)(Math.PI * i / lat);
                for (int j = 0; j <= lon; j++)
                {
                    float phi = (float)(2 * Math.PI * j / lon);
                    float x = radius * (float)(Math.Sin(theta) * Math.Cos(phi));
                    float y = radius * (float)(Math.Cos(theta));
                    float z = radius * (float)(Math.Sin(theta) * Math.Sin(phi));
                    Vertices.Add(new Point3D(x, y, z));
                }
            }

            // Conectar vértices adyacentes
            int cols = lon + 1;
            for (int i = 0; i < lat; i++)
            {
                for (int j = 0; j < lon; j++)
                {
                    int p1 = i * cols + j;
                    int p2 = p1 + 1;
                    int p3 = p1 + cols;
                    int p4 = p3 + 1;

                    edgeList.Add((p1, p2));
                    edgeList.Add((p1, p3));
                }
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

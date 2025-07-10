using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D.Shapes
{
    internal class Lily : Figure3D
    {
        public Lily(int petalCount = 6, int stamenCount = 12, float height = 2f, float radius = 1f, int curveSegments = 30)
        {
            Vertices = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            Point3D center = new Point3D(0, 0, 0);
            Vertices.Add(center);
            int centerIndex = 0;

            for (int i = 0; i < petalCount; i++)
            {
                float baseAngle = (float)(2 * Math.PI * i / petalCount);
                int prevIndex = centerIndex;

                for (int s = 1; s <= curveSegments; s++)
                {
                    float t = (float)s / curveSegments;

                    float angle = baseAngle + (float)(Math.PI * 1.5f * t);
                    float wave = 0.3f * (float)Math.Sin(6 * Math.PI * t);
                    float x = (radius * t + wave) * (float)Math.Cos(angle);
                    float y = 0.4f * (float)Math.Sin(Math.PI * t);
                    float z = (radius * t + wave) * (float)Math.Sin(angle);

                    Vertices.Add(new Point3D(x, y, z));
                    int currentIndex = Vertices.Count - 1;

                    if (s == 1)
                        edgeList.Add((centerIndex, currentIndex));
                    else
                        edgeList.Add((prevIndex, currentIndex));

                    prevIndex = currentIndex;
                }
            }

            for (int i = 0; i < stamenCount; i++)
            {
                float baseAngle = (float)(2 * Math.PI * i / stamenCount);
                int prevIndex = centerIndex;

                for (int s = 1; s <= curveSegments; s++)
                {
                    float t = (float)s / curveSegments;

                    float spiralRadius = radius * 1.3f * t;
                    float bend = 0.2f * (float)Math.Sin(Math.PI * t);

                    float angle = baseAngle + bend;
                    float x = spiralRadius * (float)Math.Cos(angle);
                    float y = 0.8f * t;
                    float z = spiralRadius * (float)Math.Sin(angle);

                    Vertices.Add(new Point3D(x, y, z));
                    int currentIndex = Vertices.Count - 1;

                    if (s == 1)
                        edgeList.Add((centerIndex, currentIndex));
                    else
                        edgeList.Add((prevIndex, currentIndex));

                    prevIndex = currentIndex;
                }
            }

            Vertices.Add(new Point3D(0, -1.5f, 0));
            edgeList.Add((centerIndex, Vertices.Count - 1));

            Edges = new int[edgeList.Count, 2];
            for (int i = 0; i < edgeList.Count; i++)
            {
                Edges[i, 0] = edgeList[i].Item1;
                Edges[i, 1] = edgeList[i].Item2;
            }
        }
    }
}

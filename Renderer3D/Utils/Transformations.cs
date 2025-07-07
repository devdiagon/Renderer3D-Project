using System;
using System.Collections.Generic;
using System.Drawing;

namespace Renderer3D.Utils
{
    internal class Transformations
    {
        public static List<PointF> Project(List<Point3D> points3D, int width, int height)
        {
            List<PointF> result = new List<PointF>();

            float fov = 45f; // en grados
            float near = 0.1f;
            float aspect = (float)width / height;
            float fovRad = fov * (float)Math.PI / 180f;
            float f = 1.0f / (float)Math.Tan(fovRad / 2f);

            float focalLength = (height / 2f) * f; // proporcional a altura

            foreach (var p in points3D)
            {
                float z = p.Z;

                // Evitar división por cero o invertir eje Z
                if (z <= near) z = near;

                float x2d = (p.X * focalLength / z) + width / 2f;
                float y2d = (p.Y * focalLength / z) + height / 2f;

                result.Add(new PointF(x2d, y2d));
            }

            return result;
        }
    }
}

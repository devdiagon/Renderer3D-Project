using System;
using System.Collections.Generic;
using System.Drawing;

namespace Renderer3D.Utils
{
    internal class Transformations
    {
        public static List<Point3D> ApplyTransformations(List<Point3D> vertices, float angleX, float angleY, float scale, Point3D translation)
        {

            List<Point3D> transformed = new List<Point3D>();

            foreach (var p in vertices)
            {
                Point3D scaled = p * scale;
                Point3D rotated = ApplyRotation(scaled, angleX, angleY);
                Point3D translated = rotated + translation;

                transformed.Add(translated);
            }

            return transformed;
        }
        public static Point3D ApplyRotationAndScale(Point3D p, float angleX, float angleY, float scale)
        {
            float cosX = (float)Math.Cos(angleX);
            float sinX = (float)Math.Sin(angleX);
            float cosY = (float)Math.Cos(angleY);
            float sinY = (float)Math.Sin(angleY);

            // Rotación en X
            float y1 = p.Y * cosX - p.Z * sinX;
            float z1 = p.Y * sinX + p.Z * cosX;

            // Rotación en Y
            float x2 = p.X * cosY + z1 * sinY;
            float z2 = -p.X * sinY + z1 * cosY;

            Point3D rotated = new Point3D(x2, y1, z2);

            return rotated * scale;
        }

        public static Point3D ApplyRotation(Point3D p, float angleX, float angleY)
        {
            float radX = angleX;
            float radY = angleY;

            float cosX = (float)Math.Cos(radX);
            float sinX = (float)Math.Sin(radX);
            float cosY = (float)Math.Cos(radY);
            float sinY = (float)Math.Sin(radY);

            // Rotación en X
            float y1 = p.Y * cosX - p.Z * sinX;
            float z1 = p.Y * sinX + p.Z * cosX;

            // Rotación en Y
            float x2 = p.X * cosY + z1 * sinY;
            float z2 = -p.X * sinY + z1 * cosY;

            return new Point3D(x2, y1, z2);
        }


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D
{
    internal class Point3D
    {
        public float X, Y, Z;
        public Point3D(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        public Point3D Clone() => new Point3D(X, Y, Z);

        public static Point3D operator +(Point3D a, Point3D b)
        {
            return new Point3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Point3D operator *(Point3D p, float scalar)
        {
            return new Point3D(p.X * scalar, p.Y * scalar, p.Z * scalar);
        }

        public static Point3D operator -(Point3D a, Point3D b)
        {
            return new Point3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
    }
}

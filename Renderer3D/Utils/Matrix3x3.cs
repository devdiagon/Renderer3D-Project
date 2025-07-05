using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer3D.Utils
{
    internal class Matrix3x3
    {
        private float[,] m;

        public Matrix3x3()
        {
            m = new float[3, 3];
            SetIdentity();
        }

        public static Matrix3x3 Identity()
        {
            Matrix3x3 mat = new Matrix3x3();
            mat.SetIdentity();
            return mat;
        }

        public void SetIdentity()
        {
            m[0, 0] = 1; m[0, 1] = 0; m[0, 2] = 0;
            m[1, 0] = 0; m[1, 1] = 1; m[1, 2] = 0;
            m[2, 0] = 0; m[2, 1] = 0; m[2, 2] = 1;
        }

        public static Matrix3x3 RotationX(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            return new Matrix3x3
            {
                m = new float[,]
                {
                {1, 0, 0},
                {0, cos, -sin},
                {0, sin, cos}
                }
            };
        }

        public static Matrix3x3 RotationY(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            return new Matrix3x3
            {
                m = new float[,]
                {
                {cos, 0, sin},
                {0, 1, 0},
                {-sin, 0, cos}
                }
            };
        }

        public static Matrix3x3 RotationZ(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            return new Matrix3x3
            {
                m = new float[,]
                {
                {cos, -sin, 0},
                {sin, cos, 0},
                {0, 0, 1}
                }
            };
        }

        public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b)
        {
            var result = new Matrix3x3();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    result.m[i, j] = a.m[i, 0] * b.m[0, j] + a.m[i, 1] * b.m[1, j] + a.m[i, 2] * b.m[2, j];

            return result;
        }

        public Point3D Transform(Point3D p)
        {
            return new Point3D(
                m[0, 0] * p.X + m[0, 1] * p.Y + m[0, 2] * p.Z,
                m[1, 0] * p.X + m[1, 1] * p.Y + m[1, 2] * p.Z,
                m[2, 0] * p.X + m[2, 1] * p.Y + m[2, 2] * p.Z
            );
        }
    }
}

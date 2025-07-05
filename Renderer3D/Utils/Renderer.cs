using Renderer3D.Shapes;
using Renderer3D.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Renderer3D
{
    internal class Renderer
    {
        public bool IsPaused { get; set; } = false;

        private Figure3D model;
        private float angleX = 0;
        private float angleY = 0;
        private float scale = 1.0f;
        private bool scalingUp = true;
        private readonly int canvasWidth, canvasHeight;

        private enum Axis { None, X, Y, Z }

        private Axis activeAxis = Axis.None;
        private DateTime axisStartTime;
        private readonly TimeSpan axisDisplayDuration = TimeSpan.FromMilliseconds(500);

        public Renderer(int width, int height)
        {
            canvasWidth = width;
            canvasHeight = height;
            model = new Cube();
            model.Position = new Point3D(0, 0, 10f);
        }

        public void SetFigure(Figure3D figure)
        {
            model = figure;
            Reset();
        }

        public void Reset()
        {
            angleX = angleY = 0;
            scale = 1.0f;
            model.Reset();
        }

        public void Update()
        {
            if (IsPaused) return;

            angleY += 0.03f;
            if (angleY > 2 * Math.PI) angleY -= (float)(2 * Math.PI);

            if (scalingUp) 
            { 
                scale += 0.01f; 
                if (scale > 1.5f) scalingUp = false; 
            }
            else 
            { 
                scale -= 0.01f; 
                if (scale < 0.5f) scalingUp = true; 
            }
        }

        public void Render(Graphics g)
        {
            g.Clear(Color.Black);
            var transformed = Transformations.ApplyTransformations(model.Vertices, angleX, angleY, scale, model.Position);
            var projected = Transformations.Project(transformed, canvasWidth, canvasHeight);

            using (Pen pen = new Pen(Color.Cyan, 2))
            {
                for (int i = 0; i < model.Edges.GetLength(0); i++)
                {
                    PointF p1 = projected[model.Edges[i, 0]];
                    PointF p2 = projected[model.Edges[i, 1]];
                    g.DrawLine(pen, p1, p2);
                }
            }

            if (activeAxis != Axis.None && DateTime.Now - axisStartTime < axisDisplayDuration)
            {
                DrawAxisIndicator(g);
            }
        }

        private void DrawAxisIndicator(Graphics g)
        {
            if (model == null) return;

            float infinity = 1000f;

            Point3D localDir;
            Color axisColor;

            switch (activeAxis)
            {
                case Axis.X: localDir = new Point3D(1, 0, 0); axisColor = Color.Red; break;
                case Axis.Y: localDir = new Point3D(0, 1, 0); axisColor = Color.Blue; break;
                case Axis.Z: localDir = new Point3D(0, 0, 1); axisColor = Color.Green; break;
                default: return;
            }

            Point3D p1 = localDir * -infinity;
            Point3D p2 = localDir * infinity;


            List<Point3D> axisLine = new List<Point3D> { p1, p2 };
            var transformed = Transformations.ApplyTransformations(axisLine, angleX, angleY, scale, model.Position);

            var projected = Transformations.Project(transformed, canvasWidth, canvasHeight);

            using (Pen axisPen = new Pen(axisColor, 2))
            {
                g.DrawLine(axisPen, projected[0], projected[1]);
            }
        }

        // Acciones de interacción (solo válidas si IsPaused)
        private float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        public void AdjustScale(float delta)
        {
            if (!IsPaused) return;
            scale = Clamp(scale + delta, 0.3f, 2.0f);
        }

        public void Move(float dx, float dy, float dz)
        {
            if(model == null) return;

            //Descomentar si se quiere tener un movimiento de forma local
            // desde el punto de vista de la figura
            Point3D localMovement = new Point3D(dx, dy, dz);

            Point3D rotatedMovement = Transformations.ApplyRotation(localMovement, angleX, angleY);

            model.Position += rotatedMovement;

            if (dx != 0) activeAxis = Axis.X;
            else if (dy != 0) activeAxis = Axis.Y;
            else if (dz != 0) activeAxis = Axis.Z;

            axisStartTime = DateTime.Now;

            //Descomentar si se quiere mantener el movimiento en X Y Z
            // desde el punto de vista del usuario, mas no de forma local desde la figura.
            //if (!IsPaused) return;
            //model.Position.X += dx;
            //model.Position.Y += dy;
            //model.Position.Z += dz;
        }

        public void Rotate(float dAngleX, float dAngleY)
        {
            if (!IsPaused) return;
            angleX += dAngleX;
            angleY += dAngleY;
        }
    }
}

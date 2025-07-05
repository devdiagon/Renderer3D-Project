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
        private Matrix3x3 rotationMatrix = Matrix3x3.Identity();
        private float scale = 1.0f;
        private bool scalingUp = true;
        private readonly int canvasWidth, canvasHeight;

        private enum Axis { None, X, Y, Z }

        private Axis activeAxis = Axis.None;
        private DateTime axisStartTime;
        private readonly TimeSpan axisDisplayDuration = TimeSpan.FromMilliseconds(500);

        private bool showLocalAxes = true;
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

        public void ToggleLocalAxes()
        {
            showLocalAxes = !showLocalAxes;
        }

        public void Reset()
        {
            rotationMatrix = Matrix3x3.Identity();
            scale = 1.0f;
            model.Reset();
        }

        public void Update()
        {
            if (IsPaused) return;

            Matrix3x3 autoRotation = Matrix3x3.RotationY(0.02f);
            rotationMatrix = autoRotation * rotationMatrix;

            autoRotation = Matrix3x3.RotationX(0.02f);
            rotationMatrix = autoRotation * rotationMatrix;

            autoRotation = Matrix3x3.RotationZ(0.02f);
            rotationMatrix = autoRotation * rotationMatrix;

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

            List<Point3D> transformed = model.Vertices
                        .Select(v => rotationMatrix.Transform(v * scale) + model.Position)
                        .ToList();

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

            if (showLocalAxes)
            {
                DrawLocalAxes(g);
            }
        }

        private void DrawAxisIndicator(Graphics g)
        {
            if (model == null) return;

            float infinity = 1000f;

            Point3D dir;
            Color axisColor;

            switch (activeAxis)
            {
                case Axis.X: dir = new Point3D(1, 0, 0); axisColor = Color.Red; break;
                case Axis.Y: dir = new Point3D(0, 1, 0); axisColor = Color.Blue; break;
                case Axis.Z: dir = new Point3D(0, 0, 1); axisColor = Color.Green; break;
                default: return;
            }

            Point3D centerLocal = model.Vertices.Aggregate(new Point3D(0, 0, 0), (acc, p) => acc + p) * (1f / model.Vertices.Count);
            Point3D centerWorld = rotationMatrix.Transform(centerLocal * scale) + model.Position;
            
            Point3D localDir = rotationMatrix.Transform(dir);
            Point3D p1 = centerWorld - localDir * infinity;
            Point3D p2 = centerWorld + localDir * infinity;

            
            var projected = Transformations.Project(new List<Point3D> { p1, p2 }, canvasWidth, canvasHeight);

            using (Pen axisPen = new Pen(axisColor, 2))
            {
                g.DrawLine(axisPen, projected[0], projected[1]);
            }
        }

        private void DrawLocalAxes(Graphics g)
        {
            if (!showLocalAxes || model == null) return;

            float axisLength = 1.5f;

            Point3D origin = model.Position;

            // Rota los ejes base (locales)
            Point3D xAxis = rotationMatrix.Transform(new Point3D(axisLength, 0, 0));
            Point3D yAxis = rotationMatrix.Transform(new Point3D(0, axisLength, 0));
            Point3D zAxis = rotationMatrix.Transform(new Point3D(0, 0, axisLength));

            // Convertir al sistema de coordenadas de pantalla
            List<Point3D> axisPoints = new List<Point3D>
            {
                origin,
                origin + xAxis,
                origin + yAxis,
                origin + zAxis
            };

            var projected = Transformations.Project(axisPoints, canvasWidth, canvasHeight);

            Pen penX = new Pen(Color.Red, 2);
            Pen penY = new Pen(Color.Blue, 2);
            Pen penZ = new Pen(Color.Green, 2);

            g.DrawLine(penX, projected[0], projected[1]);
            g.DrawLine(penY, projected[0], projected[2]);
            g.DrawLine(penZ, projected[0], projected[3]);
        }

        // Acciones de interacción
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
            if (model == null) return;

            var direction = rotationMatrix.Transform(new Point3D(dx, dy, dz));
            model.Position += direction;

            if (dx != 0) activeAxis = Axis.X;
            else if (dy != 0) activeAxis = Axis.Y;
            else if (dz != 0) activeAxis = Axis.Z;

            axisStartTime = DateTime.Now;
        }

        public void RotateX(float delta)
        {
            Matrix3x3 rotX = Matrix3x3.RotationX(delta);
            rotationMatrix = rotationMatrix * rotX;
        }

        public void RotateY(float delta)
        {
            Matrix3x3 rotY = Matrix3x3.RotationY(delta);
            rotationMatrix = rotationMatrix * rotY;
        }

        public void RotateZ(float delta)
        {
            Matrix3x3 rotZ = Matrix3x3.RotationZ(delta);
            rotationMatrix =  rotationMatrix * rotZ;
        }
    }
}

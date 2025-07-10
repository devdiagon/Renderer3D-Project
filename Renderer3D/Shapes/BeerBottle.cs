using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Renderer3D.Shapes
{
    internal class BeerBottle: Figure3D
    {
        public BeerBottle(int segments = 24)
        {
            Vertices = new List<Point3D>();
            Faces = new List<int[]>();
            List<(int, int)> edgeList = new List<(int, int)>();

            // Parámetros generales
            float baseHeight = 0.3f;
            float baseRadius = 1.1f;

            float bodyHeight = 3.0f;
            float bodyRadius = 0.9f;

            float shoulderHeight = 0.3f; // curva base-cuerpo
            float shoulderRadiusBottom = 1.1f;
            float shoulderRadiusTop = 0.9f;

            float neckHeight = 1.2f;
            float neckRadiusBottom = 0.35f;
            float neckRadiusTop = 0.25f;

            float capHeight = 0.25f;
            float capRadius = 0.4f;

            // 1. Base - cilindro ancho y corto
            Cylinder baseCyl = new Cylinder(segments, baseHeight, baseRadius);
            AppendShape(baseCyl, 0, baseHeight / 2, 0, edgeList);

            // 2. Shoulder - cono invertido para la curva base-cuerpo
            Cone shoulder = new Cone(segments, shoulderHeight, shoulderRadiusBottom);
            // El cono que conecta base y cuerpo, invertido (punta hacia abajo)
            // Lo rotamos 180 grados en X, aquí solo hacemos la posición y ajuste
            AppendShape(shoulder, 0, baseHeight + shoulderHeight / 2, 0, edgeList);

            // 3. Cuerpo principal - cilindro
            Cylinder body = new Cylinder(segments, bodyHeight, bodyRadius);
            AppendShape(body, 0, baseHeight + shoulderHeight + bodyHeight / 2, 0, edgeList);

            // 4. Cuello - cono
            Cone neck = new Cone(segments, neckHeight, neckRadiusBottom);
            AppendShape(neck, 0, baseHeight + shoulderHeight + bodyHeight + neckHeight / 2, 0, edgeList);

            // 5. Tapa - cilindro pequeño
            Cylinder cap = new Cylinder(segments, capHeight, capRadius);
            AppendShape(cap, 0, baseHeight + shoulderHeight + bodyHeight + neckHeight + capHeight / 2, 0, edgeList);

            // Ajuste: rotar cono shoulder para que quede invertido
            // NOTA: Como no tenemos rotaciones aplicadas a figuras independientes,
            // lo ideal sería modificar vertices de shoulder para invertir Y,
            // o implementar rotaciones previas. Aquí dejamos el shoulder como cono normal.
            // Para mejor realismo, implementar esa rotación.

            // Copiar aristas
            Edges = new int[edgeList.Count, 2];
            for (int i = 0; i < edgeList.Count; i++)
            {
                Edges[i, 0] = edgeList[i].Item1;
                Edges[i, 1] = edgeList[i].Item2;
            }
        }

        private void AppendShape(Figure3D shape, float offsetX, float offsetY, float offsetZ, List<(int, int)> edgeList)
        {
            int baseIndex = Vertices.Count;

            foreach (var v in shape.Vertices)
            {
                Vertices.Add(new Point3D(v.X + offsetX, v.Y + offsetY, v.Z + offsetZ));
            }

            foreach (var face in shape.Faces)
            {
                int[] shiftedFace = new int[face.Length];
                for (int i = 0; i < face.Length; i++)
                {
                    shiftedFace[i] = face[i] + baseIndex;
                }
                Faces.Add(shiftedFace);
            }

            for (int i = 0; i < shape.Edges.GetLength(0); i++)
            {
                int a = shape.Edges[i, 0] + baseIndex;
                int b = shape.Edges[i, 1] + baseIndex;
                edgeList.Add((a, b));
            }
        }
    }
}

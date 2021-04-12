using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace DatVis3D
{
    public class PolygonPlot : BasicDiagram
    {
        public PolygonPlot(Dictionary<float, dataUnit> Data) : base(Data) { }

        public override void Draw(float t)
        {
            GL.Disable(EnableCap.Lighting);
            List<Vector3> vectors = data[t].vectors;
            float minX = vectors[0].X;
            float minY = vectors[0].Y;
            float maxX = vectors[vectors.Count - 1].X;
            float maxY = vectors[vectors.Count - 1].Y;
            float stepY = vectors[1].Y - vectors[0].Y;
            int countY = Convert.ToInt32((maxY - minY) / stepY);
            float stepX = vectors[countY+1].X - vectors[0].X;
            int countX = Convert.ToInt32((maxX - minX) / stepX);
            

            for (int x = 0; x < countX-1; x++)
                for (int y = 0; y < countY-1; y += 1)
                {
                    Vector3 leftUp = vectors[x * countY + y];
                    Vector3 leftBot = vectors[(x + 1) * countY + y];
                    Vector3 rightBot = vectors[(x + 1) * countY + y + 1];
                    Vector3 rightUp = vectors[x * countY + y + 1];
                    GL.Begin(PrimitiveType.Polygon);
                    //Верхняя левая
                    int red = Convert.ToInt32(255 * (leftUp.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ));
                    int green = 255 - red;
                    GL.Color3(Color.FromArgb(red, green, 0));
                    GL.Vertex3(leftUp.X, leftUp.Y, leftUp.Z);
                    //Нижняя левая
                    red = Convert.ToInt32(255 * (leftBot.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ));
                    green = 255 - red;
                    GL.Color3(Color.FromArgb(red, green, 0));
                    GL.Vertex3(leftBot.X, leftBot.Y, leftBot.Z);
                    //Нижняя правая
                    red = Convert.ToInt32(255 * (rightBot.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ));
                    green = 255 - red;
                    GL.Color3(Color.FromArgb(red, green, 0));
                    GL.Vertex3(rightBot.X, rightBot.Y, rightBot.Z);
                    //Верхняя праая
                    red = Convert.ToInt32(255 * (rightUp.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ));
                    green = 255 - red;
                    GL.Color3(Color.FromArgb(red, green, 0));
                    GL.Vertex3(rightUp.X, rightUp.Y, rightUp.Z);
                    GL.End();
                }
            GL.Enable(EnableCap.Lighting);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Threading.Tasks;

namespace DatVis3D
{
    public class BarPlot : BasicDiagram
    {
        public BarPlot(Dictionary<float, dataUnit> Data) : base(Data) { }

        public float ThicknessX { get; set; } = 10f;
        public float ThicknessY { get; set; } = 10f;

        public override void Draw(float t)
        {
            GL.Disable(EnableCap.Lighting);
            foreach (Vector3 vec in data[t].vectors)
            {
                GL.Begin(PrimitiveType.QuadStrip);
                GL.Vertex3((vec.X - 0.5f) * ThicknessX, (vec.Y - 0.5f) * ThicknessY, 0);
                GL.Vertex3((vec.X - 0.5f) * ThicknessX, (vec.Y - 0.5f) * ThicknessY, vec.Z);
                GL.Vertex3((vec.X + 0.5f) * ThicknessX, (vec.Y - 0.5f) * ThicknessY, 0);
                GL.Vertex3((vec.X + 0.5f) * ThicknessX, (vec.Y - 0.5f) * ThicknessY, vec.Z);
                GL.Vertex3((vec.X + 0.5f) * ThicknessX, (vec.Y + 0.5f) * ThicknessY, 0);
                GL.Vertex3((vec.X + 0.5f) * ThicknessX, (vec.Y + 0.5f) * ThicknessY, vec.Z);
                GL.Vertex3((vec.X - 0.5f) * ThicknessX, (vec.Y + 0.5f) * ThicknessY, 0);
                GL.Vertex3((vec.X - 0.5f) * ThicknessX, (vec.Y + 0.5f) * ThicknessY, vec.Z);
                GL.Vertex3((vec.X - 0.5f) * ThicknessX, (vec.Y - 0.5f) * ThicknessY, 0);
                GL.End();
            }
            GL.Enable(EnableCap.Lighting);
        }
    }
}

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
    class BarPlot : BasicDiagram
    {
        public BarPlot(Dictionary<float, dataUnit> Data) : base(Data) { }

        public float BarThicknessX { get; set; } = 10f;
        public float BarThicknessY { get; set; } = 10f;

        public override void Draw(float t)
        {
            GL.Disable(EnableCap.Lighting);
            foreach (Vector3 vec in data[t].vectors)
            {
                GL.Begin(PrimitiveType.QuadStrip);
                GL.Vertex3(vec );
                GL.End();

            }
            GL.Enable(EnableCap.Lighting);
        }
    }
}

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
    public class DotPlot : BasicDiagram
    {
        public DotPlot(Dictionary<float, dataUnit> Data) : base(Data) { }

        public override void Draw(float t)
        {
            GL.Disable(EnableCap.Lighting);
            foreach (Vector3 vec in data[t].vectors)
            {
                int red = Convert.ToInt32(255 * (vec.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ));
                int green = 255 - red;
                GL.Color3(Color.FromArgb(red, green, 0));
                GL.Begin(PrimitiveType.Points);
                GL.Vertex3(vec.X, vec.Y, vec.Z);
                GL.End();
            }
            GL.Enable(EnableCap.Lighting);
        }
    }
}

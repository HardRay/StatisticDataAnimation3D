using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Threading.Tasks;
using OpenTK.Graphics;
using System.Windows.Forms;

namespace DatVis3D
{
    public class BarPlot : BasicDiagram
    {
        Dictionary<float, float> xColor;

        public BarPlot(Dictionary<float, dataUnit> Data) : base(Data) 
        {
            xColor = Data.Values
                .SelectMany(d => d.vectors.Select(v => v.X))
                .Distinct()
                .ToDictionary(x => x);

            var maxX = xColor.Keys.Max();
            var keys = xColor.Keys.ToArray();
            foreach (float key in keys)
                xColor[key] = key / maxX;
        }

        public float ThicknessX { get; set; } = 10f;
        public float ThicknessY { get; set; } = 15f;

        public override void Draw(float t)
        {
            Random rnd = new Random();
            foreach (Vector3 vec in data[t].vectors)
            {
                // Рассчет точек
                var LLL = new Vector3((vec.X - 0.35f) * ThicknessX, (vec.Y - 0.35f) * ThicknessY, 0);
                var HLL = new Vector3((vec.X + 0.35f) * ThicknessX, (vec.Y - 0.35f) * ThicknessY, 0);
                var HHL = new Vector3((vec.X + 0.35f) * ThicknessX, (vec.Y + 0.35f) * ThicknessY, 0);
                var LHL = new Vector3((vec.X - 0.35f) * ThicknessX, (vec.Y + 0.35f) * ThicknessY, 0);
                var LLH = new Vector3((vec.X - 0.35f) * ThicknessX, (vec.Y - 0.35f) * ThicknessY, vec.Z);
                var HLH = new Vector3((vec.X + 0.35f) * ThicknessX, (vec.Y - 0.35f) * ThicknessY, vec.Z);
                var HHH = new Vector3((vec.X + 0.35f) * ThicknessX, (vec.Y + 0.35f) * ThicknessY, vec.Z);
                var LHH = new Vector3((vec.X - 0.35f) * ThicknessX, (vec.Y + 0.35f) * ThicknessY, vec.Z);
                var saturation = (vec.Z - data[t].minZ) / (data[t].maxZ - data[t].minZ);
                var color = Color4.FromHsv(new Vector4(xColor[vec.X], saturation, saturation, 1f));
                GL.Material(MaterialFace.Front, MaterialParameter.AmbientAndDiffuse, color);
                GL.Begin(PrimitiveType.Quads);
                // Левая грань
                GL.Normal3(-1, 0, 0);
                GL.Vertex3(LLL);
                GL.Vertex3(LLH);
                GL.Vertex3(LHH);
                GL.Vertex3(LHL);
                // Нижняя грань
                GL.Normal3(0, -1, 0);
                GL.Vertex3(HLL);
                GL.Vertex3(HLH);
                GL.Vertex3(LLH);
                GL.Vertex3(LLL);
                // Правая грань
                GL.Normal3(1, 0, 0);
                GL.Vertex3(HHL);
                GL.Vertex3(HHH);
                GL.Vertex3(HLH);
                GL.Vertex3(HLL);
                // Верхняя грань
                GL.Normal3(0, 1, 0);
                GL.Vertex3(LHL);
                GL.Vertex3(LHH);
                GL.Vertex3(HHH);
                GL.Vertex3(HHL);
                // "Крыша"
                GL.Normal3(0, 0, 1);
                GL.Vertex3(HLH);
                GL.Vertex3(HHH);
                GL.Vertex3(LHH);
                GL.Vertex3(LLH);
                // "Пол"
                GL.Normal3(0, 0, -1);
                GL.Vertex3(HLL);
                GL.Vertex3(HHL);
                GL.Vertex3(LHL);
                GL.Vertex3(LLL);
                GL.End();
            }
        }

        public void DrawLegend(Graphics g, int Width, int Height , List<string> histX)
        {
            int xPos = Convert.ToInt32(Width * 0.1), yPos = Height / 10;
            foreach (var x in xColor)
            {
                var color = Color4.FromHsv(new Vector4(x.Value, 1f, 1f, 1f));
                var brush = new SolidBrush(Color.FromArgb(color.ToArgb()));
                g.FillRectangle(brush, xPos, yPos, 25, 15);
                g.DrawString(histX[Convert.ToInt32(x.Key)], SystemFonts.DefaultFont, brush, xPos + 30, yPos);
                yPos += 30;
            }           
        }

        public float[] GenerateIntermediateData(int dynamicNum = 20, int staticFrame = 8)
        {
            var time = data.Keys.OrderBy(k => k).ToArray();
            for (int t = 0; t < time.Count() - 1; t++)
            {
                float diff = time[t + 1] - time[t];
                float step = diff / (dynamicNum + staticFrame * 2);
                var vecDiff = data[time[t + 1]].vectors.Zip(data[time[t]].vectors, (f, s) => (f - s) / dynamicNum);
                for (float f = time[t] + step; f < time[t + 1]; f += step)
                {
                    if ((f - time[t]) / step < staticFrame)
                    {
                        data[f] = data[time[t]];
                        continue;
                    }
                    if ((time[t + 1] - f) / step < staticFrame)
                    {
                        data[f] = data[time[t + 1]];
                        continue;
                    }
                    var newpoint = data[f - step].vectors.Zip(vecDiff, (p, n) => p + n);
                    var maxZ = newpoint.Max(p => p.Z);
                    var minZ = newpoint.Min(p => p.Z);
                    data[f] = new dataUnit(newpoint.ToList(), minZ, maxZ);
                }
            }
            float[] keys = new float[data.Keys.Count];
            data.Keys.CopyTo(keys, 0);
            Array.Sort(keys);
            return keys;
        }
    }
}

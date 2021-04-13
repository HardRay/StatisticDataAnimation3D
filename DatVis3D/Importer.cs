using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Sprache.Calc;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.IO;
using System.Windows.Forms;

namespace DatVis3D
{
    public static class Importer
    {
        public enum Axis { X, Y, Z, T }

        public static Dictionary<float, dataUnit> GetDataFromEquation(string equa, double minX, double maxX, double minY, double maxY, double minT, double maxT, Action<int> del, double stepX = 1, double stepY = 1, double stepT = 1)
        {
            Dictionary<float, dataUnit> data = new Dictionary<float, dataUnit>();
            var calc = new Sprache.Calc.XtensibleCalculator();
            // using expressions
            try {
                var func = calc.ParseFunction(equa).Compile();
                Dictionary<string, double> parameters;
                double percent = 0;
                for (double t = minT; t <= maxT; t += stepT)
                {
                    double max = 0, min = 0;
                    bool maxFlag = true, minFlag = true;
                    percent += stepT / (maxT - minT) * 100;
                    if (percent > 100)
                        percent = 100;
                    del(Convert.ToInt32(percent));
                    List<Vector3> vectors = new List<Vector3>();
                    for (double x = minX; x <= maxX; x += stepX)
                        for (double y = minY; y <= maxY; y += stepY)
                        {
                            parameters = new Dictionary<string, double> { { "x", x }, { "y", y }, { "t", t } };
                            float z = (float)func(parameters);
                            if (minFlag || z < min)
                            {
                                minFlag = false;
                                min = z;
                            }
                            if (maxFlag || z > max)
                            {
                                maxFlag = false;
                                max = z;
                            }
                            vectors.Add(new Vector3((float)x, (float)y, z));
                        }
                    data.Add((float)t, new dataUnit(vectors, (float)min, (float)max));
                }
                return data;
            }
            catch { return data; }
        }



        public static Dictionary<float, dataUnit> GetDataFromTable(string filepath, List<Tuple<string, Axis>> headers, Action<int> del)
        {
            if (Path.GetExtension(filepath) == ".txt")
                return LoadFromTxt(filepath, headers, del);
            else
                return LoadFromExcel(filepath, headers, del);
        }

        public static string[] LoadHeaders(string filepath)
        {
            if (Path.GetExtension(filepath) == ".txt")
                return LoadHeadersFromTxt(filepath);
            else
                return LoadHeadersFromExcel(filepath);
        }

        private static string[] LoadHeadersFromTxt(string filepath)
        {
            using (var file = new StreamReader(filepath))
            {
                string line = file.ReadLine();
                var headers = line.Split(new char[] { '\t' });
                if (headers.Length < 4)
                {
                    MessageBox.Show("Слишком мало параметров", "Ошибка: Некорректный файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return headers;
            }
        }

        private static string[] LoadHeadersFromExcel(string filepath)
        {
            return null;
        }


        private static Dictionary<float, dataUnit> LoadFromTxt(string filepath, List<Tuple<string, Axis>> headers, Action<int> del)
        {
            del(10);
            int numT = headers.FindIndex(h => h.Item2 == Axis.T);
            int numX = headers.FindIndex(h => h.Item2 == Axis.X);
            int numY = headers.FindIndex(h => h.Item2 == Axis.Y);
            int numZ = headers.FindIndex(h => h.Item2 == Axis.Z);
            var histX = new List<string>();
            var histY = new List<string>();
            var rezult = new Dictionary<float, dataUnit>();

            using (var file = new StreamReader(filepath))
            {
                file.ReadLine();
                if (file.EndOfStream)
                {
                    MessageBox.Show("Файл не содержит данных", "Ошибка: Некорректный файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                del(30);
                do
                {
                    string line = file.ReadLine();
                    var columns = line.Split(new char[] { '\t' });
                    if (columns.Length < 4)
                    {
                        MessageBox.Show("Слишком мало параметров", "Ошибка: Некорректный файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    if (!float.TryParse(columns[numT], out float T) || !float.TryParse(columns[numZ], out float Z))
                    {
                        MessageBox.Show("T и Z должены быть числом", "Ошибка: Некорректный файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    if (!float.TryParse(columns[numX], out float X))
                    {
                        if (histX.Contains(columns[numX]))
                            X = histX.FindIndex(x => x == columns[numX]);
                        else
                        {
                            X = histX.Count;
                            histX.Add(columns[numX]);
                        }
                    }

                    if (!float.TryParse(columns[numY], out float Y))
                    {
                        if (histY.Contains(columns[numY]))
                            Y = histY.FindIndex(y => y == columns[numY]);
                        else
                        {
                            Y = histY.Count;
                            histY.Add(columns[numY]);
                        }
                    }

                    if (rezult.Keys.Contains(T))
                    {
                        if (rezult[T].maxZ < Z) rezult[T].maxZ = Z;
                        if (rezult[T].minZ > Z) rezult[T].minZ = Z;
                        rezult[T].vectors.Add(new Vector3(X, Y, Z));
                    }
                    else
                        rezult.Add(T, new dataUnit(new List<Vector3> { new Vector3(X, Y, Z) }, Z, Z));
                } while (!file.EndOfStream);
            }
            del(100);
            return rezult;
        }

        private static Dictionary<float, dataUnit> LoadFromExcel(string filepath, List<Tuple<string, Axis>> headers, Action<int> del)
        {
            return null;
        }
    }
}

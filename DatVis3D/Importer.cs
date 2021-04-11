﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Sprache.Calc;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DatVis3D
{
    public static class Importer
    {

        public static Dictionary<float, List<Vector3>> GetDataFromEquation(string equa, double minX, double maxX, double minY, double maxY, double minT, double maxT, Action<int> del, double stepX = 1, double stepY = 1, double stepT = 1)
        {
            Dictionary<float, List<Vector3>> data = new Dictionary<float, List<Vector3>>();
            var calc = new Sprache.Calc.XtensibleCalculator();
            // using expressions
            try {
                var func = calc.ParseFunction(equa).Compile();
                Dictionary<string, double> parameters;
                double percent = 0;
                for (double t = minT; t < maxT; t += stepT)
                {
                    percent += stepT / (maxT - minT) * 100;
                    if (percent > 100)
                        percent = 100;
                    del(Convert.ToInt32(percent));
                    List<Vector3> vec = new List<Vector3>();
                    for (double x = minX; x < maxX; x += stepX)
                        for (double y = minY; y < maxY; y += stepY)
                        {
                            parameters = new Dictionary<string, double> { { "x", x }, { "y", y }, { "t", t } };
                            vec.Add(new Vector3((float)x, (float)y, (float)func(parameters)));
                        }
                    data.Add((float)t, vec);
                }
                return data;
            }
            catch { return data; }
        }
    }
}

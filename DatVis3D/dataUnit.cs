using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace DatVis3D
{
    public class dataUnit
    {
        public List<Vector3> vectors { get; }
        public float maxZ { get; protected internal set;  }
        public float minZ { get; protected internal set;  }

        public dataUnit(List<Vector3> data, float min, float max)
        {
            vectors = data;
            minZ = min;
            maxZ = max;
        }
    }
}

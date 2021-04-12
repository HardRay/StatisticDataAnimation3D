using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;


namespace DatVis3D
{
    public abstract class BasicDiagram
    {
        // Данные
        protected Dictionary<float, dataUnit> data;

        public BasicDiagram(Dictionary<float, dataUnit> Data)
        {
            data = Data;
        }

        //Метод отрисовки
        public virtual void Draw(float t)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Formas
    {
        private float _area;
        private float _perimetro;

        public float Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public float Perimetro
        {
            get { return _perimetro; }
            set { _perimetro = value; }
        }

        public Formas()
        {
           
        }
    }
}

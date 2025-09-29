using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Elipse:Formas
    {
        private float _radio1;
        private float _radio2;

        public float Radio1
        {
            get { return _radio1; }
            set { _radio1 = value; }
        }
        public float Radio2
        {
            get { return _radio2; }
            set { _radio2 = value; }
        }
        public Elipse(float radius1, float radius2)
        {
            Radio1 = radius1;
            Radio2 = radius2;
            CalcularArea();
            CalcularPerimetroElipse();
        }

        public void CalcularArea()
        {
            Area = (float)(Math.PI * Radio1 * Radio2);
        }
        public void CalcularPerimetroElipse()
        {
            Perimetro = (float)(Math.PI*(3*(Radio1 + Radio2)-Math.Sqrt((3*Radio1*Radio2)*(Radio1 + 3*Radio2))));
        }
    }
}

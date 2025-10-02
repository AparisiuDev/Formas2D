using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Circulo:Elipse
    {
        public Circulo(float radio) : base(radio, radio)
        {

        }

        public float CalcularPerimetroCirculo()
        {
            return (float)(2 * Math.PI * Radio1);
        }
    }
}

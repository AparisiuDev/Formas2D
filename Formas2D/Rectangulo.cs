using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Rectangulo:Poligono
    {
        public Rectangulo(float baseSuelo, float altura): base(baseSuelo, altura, 4)
        {
            Area += CalcularArea();
            CalcularPerimetro();
        }

        public float CalcularArea()
        {
            return BaseSuelo * Altura;
        }
        public float CalcularPerimetro()
        {
            return (BaseSuelo*2) + (Altura*2);
        }
    }
}

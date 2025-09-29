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

        }

        public void CalcularArea()
        {
            Area = BaseSuelo * Altura;
        }
        public void CalcularPerimetro()
        {
            Perimetro = (BaseSuelo*2) + (Altura*2);
        }
    }
}

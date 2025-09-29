using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Triangulo:Poligono
    {
        public Triangulo(float baseSuelo, float altura):base(baseSuelo, altura, 3)
        {

        }

        public void CalcularArea()
        {
            Area = (BaseSuelo * Altura) / 2;
        }
        public void CalcularPerimetro()
        {
            float lado = (float)Math.Sqrt(Math.Pow(BaseSuelo / 2, 2) + Math.Pow(Altura, 2));
            Perimetro = BaseSuelo + 2 * lado;
        }
    }
}

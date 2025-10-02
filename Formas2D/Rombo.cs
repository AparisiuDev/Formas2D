using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Rombo:Poligono
    {
        public Rombo(float diagonalVertical, float diagonalHorizontal):base(diagonalVertical, diagonalHorizontal, 4)
        {
            Area += CalcularArea();
            CalcularPerimetro();
        }
        public float CalcularArea()
        {
            return (BaseSuelo * Altura) / 2;
        }
        public float CalcularPerimetro()
        {
            return (float)(2 * (Math.Sqrt(Math.Pow(BaseSuelo, 2) + Math.Pow(Altura, 2))));
        }
    }
}

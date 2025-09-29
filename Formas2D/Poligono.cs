using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Poligono:Formas
    {
        private float _baseSuelo;
        private float _altura;
        private int _numLados;

        public float BaseSuelo
        {
            get { return _baseSuelo; }
            set { _baseSuelo = value; }
        }
        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        public int NumLados
        {
            get { return _numLados; }
            set { _numLados = value; }
        }

        public Poligono(float baseSuelo, float altura, int numLados)
        {
            BaseSuelo = baseSuelo;
            Altura = altura;
            NumLados = numLados;
        }
    }
}

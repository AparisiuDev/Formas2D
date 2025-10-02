using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Diagrama
    {
        private List<Formas> _formas;
        private float _areaTotal;

        public List<Formas> FormasConjunto
        {
            get { return _formas; } 
            set { _formas = value; }
        }
        public float AreaTotal { get { return _areaTotal; } }

        public Diagrama()
        {
            FormasConjunto = new List<Formas>();
        }
         public void AddFormes()
        {
            Console.Clear();
            int opcion = 0;
            //Try
            Console.WriteLine("Selecciona que forma quieres añadir");
            Console.WriteLine("\n1.Cuadrado\n" +
                "2.Rectangulo\n" +
                "3.Triangulo\n" +
                "4.Rombo\n" +
                "5.Circulo\n" +
                "6.Elipse\n");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: No ingresaste un num correcto.");
                Console.ReadKey();
                AddFormes();
            }

            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escribe el tamaño de los lados");
                    FormasConjunto.Add(new Cuadrado(int.Parse(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("Escribe el tamaño de la base y de la altura");
                    FormasConjunto.Add(new Rectangulo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine("Escribe el tamaño de la base y de la altura");
                    FormasConjunto.Add(new Triangulo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine("Escribe el tamaño de la diagonal horizontal y vertical");
                    FormasConjunto.Add(new Rombo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 5:
                    Console.WriteLine("Escribe el radio del circulo");
                    FormasConjunto.Add(new Circulo(int.Parse(Console.ReadLine())));
                    break;
                case 6:
                    Console.WriteLine("Escribe los radios de la elipse");
                    FormasConjunto.Add(new Elipse(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                default:
                    break;

            }
        }

        public float CalcularAreaTotal()
        {
            float areaTotal = 0;
            foreach (var formas in FormasConjunto)
            {
                areaTotal += formas.Area;
            }
            return areaTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diagrama diagrama = new Diagrama();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1.Añadir forma\n" +
                    "2.Ver area total\n" +
                    "3.Salir\n");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        diagrama.AddFormes();
                        break;
                    case 2:
                        Console.WriteLine($"El total de area es de {diagrama.CalcularAreaTotal()} cm");
                        Console.ReadKey();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input no reconocido");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

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
                Console.Clear();
                Console.WriteLine("1.Añadir forma\n" +
                    "2.Ver area total\n" +
                    "3.Salir\n");
                int n = 0;
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: No ingresaste un num correcto.");
                    Console.ReadKey();
                }
                switch (n)
                {
                    case 1:
                        Console.Clear();
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
                        break;
                }
            }
        }
    }
}

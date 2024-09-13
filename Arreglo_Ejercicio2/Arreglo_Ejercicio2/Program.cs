using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaArreglo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0, c = 0, suma = 0;

            /*Console.Write("Ingrese la cantidad de filas: ");
            f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            c = Convert.ToInt32(Console.ReadLine());*/

            Console.WriteLine("Programa usando arreglos Bidimencionales");
            Console.WriteLine("Digite los datos del arreglo: ");

            int[,] tabla1 = new int[3, 3];

            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Imprimiendo el arreglo...");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(tabla1[f, c] + "   ");
                }
                Console.WriteLine();
            }

            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    suma += tabla1[f, c];
                }
            }
            Console.WriteLine();
            Console.WriteLine("La suma es: {0}", suma);
            Console.ReadKey();
        }
    }
}

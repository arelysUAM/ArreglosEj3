/*• El código
El siguiente código crea un arreglo de enteros de 6 posiciones, se llena con números
proporcionados por el usuario desde el teclado y finalmente lo muestra en pantalla:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaArreglos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            int tamano = 10;
            int contadorPar = 0, contadorImpar = 0;
            int[] numeros = new int[tamano];
            Console.WriteLine("Digite los datos del arreglo ");
            Console.WriteLine();
            for (int i = 0; i < tamano; i++)
            {
                Console.Write("Ingresa un número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo: ");
            for (int i = 0; i < tamano; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    contadorPar++;
                }
                else
                {
                    contadorImpar++;
                }
            }
            Console.WriteLine("Total de pares: {0}", contadorPar);
            Console.WriteLine("Total de Impares: {0}", contadorImpar);
            Console.ReadKey();
        }
    }
}

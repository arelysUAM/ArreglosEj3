/*Ejercicio 3
 Su impresión en forma tabular deberá incluir estos totales a la derecha 
de los renglones totalizados y en la parte inferior de las columnas totalizadas.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productos = 5, vendedores = 4;
            int p = 0, v = 0;
            decimal totalGeneral = 0, venta;

            decimal[,] sales = new decimal[productos, vendedores]; //ventas de cada vendedor por producto
            decimal[] salesVendedores = new decimal[vendedores]; //total vendido por cada vendedor
            decimal[] salesProductos = new decimal[productos]; //total vendido por cada producto


            for (v = 0; v < vendedores; v++)
            {
                Console.WriteLine("Vendedor #{0}", v + 1);
                Console.WriteLine();
                for (p = 0; p < productos; p++)
                {
                    Console.WriteLine("Producto #{0}", p + 1);
                    Console.Write("Total de venta: $"); //solicitar la venta de cada vendedor por producto
                    venta = decimal.Parse(Console.ReadLine());
                    while (venta < 0) // Verificar si el monto ingresado es válido
                    {
                        Console.WriteLine("El monto no puede ser menor a $0.");
                        Console.WriteLine();
                        Console.Write("Total de venta: $");
                        venta = decimal.Parse(Console.ReadLine());
                    }
                    sales[p, v] = venta; // se guarda la  venta ingresada
                    salesVendedores[v] += venta; // actualización de total de venta por vendedores
                    salesProductos[p] += venta; // actualización de total de venta por productos
                }
                Console.Clear();
            }
            Console.WriteLine("Reporte");
            Console.Write("Producto      "); //Encabezado

            for (v = 0; v < vendedores; v++)
            {
                Console.Write("Vendedor {0}     ", v + 1); //Encabezado
            }
            Console.Write("TotalxVendedor"); // Encabezado
            Console.WriteLine();

            for (p = 0; p < productos; p++)
            {
                Console.Write("Producto {0}      ", p + 1);
                for (v = 0; v < vendedores; v++)
                {
                    Console.Write("${0:f2}        ", sales[p, v]); //se imprimen los datos de venta por producto y vendedor
                }
                Console.WriteLine("${0:f2}", salesProductos[p]); // total por cada producto
            }
            Console.Write("TotalxProducto   ");
            for (v = 0; v < vendedores; v++)
            {
                Console.Write("${0:f2}       ", salesVendedores[v]); // total vendido por vendedor
                totalGeneral += salesVendedores[v]; // suma de totales por vendedor
            }
            Console.WriteLine("${0:f2}", totalGeneral); // imprimir total general
            Console.ReadKey();
        }
    }
}

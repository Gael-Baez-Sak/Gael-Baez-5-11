using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int precio, cantidad, total;
            string linea;

            Console.Write("Ingrese el precio del producto: ");
            linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.Write("Ingrese la cantidad a llevar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            total = precio * cantidad;

            Console.WriteLine("El total es: " + total);

            Console.ReadKey();
        }
    }
}

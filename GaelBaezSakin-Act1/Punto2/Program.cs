using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.

            int num1, num2, num3, num4, suma, producto;
            string linea;

            Console.Write("Ingrese un valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese un valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese un valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese un valor: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;

            Console.WriteLine("La suma de los dos primeros es: " + suma);
            Console.WriteLine("El producto de los dos ultimos es: " + producto);

            Console.ReadKey();
        }
    }
}

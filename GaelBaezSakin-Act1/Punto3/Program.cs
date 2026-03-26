using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            int num1, num2, num3, num4, suma, promedio;
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

            suma = num1 + num2 + num3 + num4;
            promedio = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("La suma de los dos primeros es: " + suma);
            Console.WriteLine("El promedio de los valores es: " + promedio);

            Console.ReadKey();
        }
    }
}

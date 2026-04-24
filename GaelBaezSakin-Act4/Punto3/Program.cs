using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto3
{
    //Realizar un programa que acumule (sume) valores ingresados por teclado hasta
    //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
    //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulado = 0;

            Console.WriteLine("Ingrese valores para sumar (9999 para finalizar):");

            do
            {
                Console.Write("Valor: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 9999)
                {
                    acumulado = acumulado + numero;
                    Console.WriteLine("El valor acumulado es: " + acumulado);
                }

            } while (numero != 9999);

            Console.WriteLine("\nEl valor acumulado total es: " + acumulado);

            if (acumulado == 0)
            {
                Console.WriteLine("El valor acumulado es cero.");
            }
            else if (acumulado > 0)
            {
                Console.WriteLine("El valor acumulado es mayor a cero.");
            }
            else
            {
                Console.WriteLine("El valor acumulado es menor a cero.");
            }
            Console.ReadKey();
        }
    }
}

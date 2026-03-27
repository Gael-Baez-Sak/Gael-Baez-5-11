using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            // Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            //39.

            int valor, tablaMulti, resultado;
            string linea;

            Console.Write("Ingresa un numero del 1 al 10: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            for (tablaMulti = 1; tablaMulti <= 13; tablaMulti++) {

                resultado = valor * tablaMulti;
                Console.WriteLine(resultado);
            
            }
            Console.ReadKey();
        }
    }
}

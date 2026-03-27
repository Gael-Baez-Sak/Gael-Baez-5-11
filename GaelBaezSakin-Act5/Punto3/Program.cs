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
            /*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/

            int i, numero, negativos, positivos, cantidadMultiplos15, numerosPares;
            string linea;

            negativos = 0;
            positivos = 0;
            cantidadMultiplos15 = 0;
            numerosPares = 0;

            for(i = 1; i <= 10; i++)
            {

                Console.Write("Ingresa un numero (positivo o negativo): ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                if (numero < 0) {

                    negativos = negativos + 1;
                    Console.WriteLine("Tu numero es negativo");

                }
                else
                {
                    positivos = positivos + 1;
                    Console.WriteLine("Tu numero es positivo");
                } if (numero % 15 == 0) { 
                
                    cantidadMultiplos15 = cantidadMultiplos15 + 1;
                    Console.WriteLine("Tu numero es multiplo de 15");
                
                }
                if (numero % 2 == 0) {
                
                    numerosPares = numerosPares + 1;
                    Console.WriteLine("Tu numero es par");
                
                }
            }
            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de multiplos de 15: " + cantidadMultiplos15);
            Console.WriteLine("Cantidad de numeros pares: " + numerosPares);

            Console.ReadKey();
        }
    }
}

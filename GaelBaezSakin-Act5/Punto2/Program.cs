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
            /*Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/

            int i, n, lado1, lado2, lado3, equilatero, isosceles, escaleno;
            string linea;

            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
            equilatero = 0;
            isosceles = 0;
            escaleno = 0;

            Console.Write("Ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Triangulo " + i);

                Console.Write("Ingresa el primer valor de un lado de un triangulo: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("Ingresa el segundo valor de un lado de un triangulo: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("Ingresa el tercer valor de un lado de un triangulo: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado2 == lado3)
                {

                    equilatero = equilatero + 1;
                    Console.WriteLine("Tu triangulo es Equilatero :)");

                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        isosceles = isosceles + 1;
                        Console.WriteLine("Tu triangulo es Isosceles :p");
                    }
                    else
                    {
                        escaleno = escaleno + 1;
                        Console.WriteLine("Tu triangulo es Escaleno :J");
                    }

                }
            }

            Console.WriteLine("Cantidad de equilateros: " + equilatero);
            Console.WriteLine("Cantidad de isosceles: " + isosceles);
            Console.WriteLine("Cantidad de escalenos: " + escaleno);

            if (equilatero < isosceles && equilatero < escaleno)
            {
                Console.WriteLine("El triangulo con menor cantidad es: Equilatero");
            }
            else
            {
                if (isosceles < escaleno)
                {
                    Console.WriteLine("El triangulo con menor cantidad es: Isosceles");
                }
                else
                {
                    Console.WriteLine("El triangulo con menor cantidad es: Escaleno");
                }
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int lado, perimetro;
            string linea;


            Console.Write("Ingrese un valor del lado de un cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            perimetro = lado * 4;

            Console.WriteLine("El perimetro es: " + perimetro);

            Console.ReadKey();
        }
    }
}

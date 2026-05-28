using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
//Implementar la clase operaciones.Se deben cargar dos valores enteros en el
//constructor, calcular su suma, resta, multiplicación y división, cada una en un
//método, imprimir dichos resultados.
    class Operaciones
    {
        private int num1, num2, suma, resta, multiplicacion, division;

        public Operaciones()
        {
            Console.Write("Ingrese el primer numero: ");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }

        public void Sumar()
        {
            suma = num1 + num2;
        }
        public void Restar()
        {
            resta = num1 - num2;
        }
        public void Multiplicar()
        {
            multiplicacion = num1 * num2;
        }
        public void Dividir()
        {
            division = num1 / num2;
        }
        public void ImprimirResultados()
        {
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            Console.WriteLine("La division es: " + division);
        }
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            o.Sumar();
            o.Restar();
            o.Multiplicar();
            o.Dividir();
            o.ImprimirResultados();
        }
    }
}


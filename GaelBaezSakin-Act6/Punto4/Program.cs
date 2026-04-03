using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Implementar la clase operaciones. Se deben cargar dos valores enteros,
    //calcular su suma, resta, multiplicación y división, cada una en un método,
    //imprimir dichos resultados.
    class Operaciones
    {
        private int valor1;
        private int valor2;

        public void CargarValores()
        {
            Console.Write("Ingrese el primer valor entero: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor entero: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void Sumar()
        {
            int suma = valor1 + valor2;
            Console.WriteLine($"La suma de {valor1} + {valor2} es: {suma}");
        }

        public void Restar()
        {
            int resta = valor1 - valor2;
            Console.WriteLine($"La resta de {valor1} - {valor2} es: {resta}");
        }

        public void Multiplicar()
        {
            int multi = valor1 * valor2;
            Console.WriteLine($"La multiplicación de {valor1} * {valor2} es: {multi}");
        }

        public void Dividir()
        {
            if (valor2 != 0)
            {
                double division = (double)valor1 / valor2;
                Console.WriteLine($"La división de {valor1} / {valor2} es: {division}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.CargarValores();

            Console.WriteLine("\n--- Resultados ---");
            op.Sumar();
            op.Restar();
            op.Multiplicar();
            op.Dividir();

            Console.ReadKey();
        }
    }
}
        
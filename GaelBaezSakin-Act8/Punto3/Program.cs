using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Cargar un vector de n elementos de tipo entero.Ordenar posteriormente el vector
    //(el orden lo pueden elegir ustedes).
    internal class ordenarVector
    {
        private int[] Vector;

        public void cargarElementos()
        {
            Console.Write("Ingresa cuantos elementos tiene el vector: ");
            int n = int.Parse(Console.ReadLine());
            Vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingresa el elemento {i + 1}: ");
                Vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ordenar()
        {
            Array.Sort(Vector);
        }
        public void imprimir()
        {
            foreach (int valor in Vector)
            {
                Console.WriteLine("- " + valor);
            }
        }
        static void Main(string[] args)
        {
            ordenarVector ov = new ordenarVector();
            ov.cargarElementos();
            ov.ordenar();
            ov.imprimir();

            Console.ReadKey();
        }
    }
}

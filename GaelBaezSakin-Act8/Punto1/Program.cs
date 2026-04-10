using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Cargar un vector de n elementos. Imprimir el menor y un mensaje si se repite dentro
    //del vector.
    internal class Programa
    {
        private int[] vector;

        public void cargarElementos()
        {
            Console.Write("Ingresa cuantos elementos tiene el vector: ");
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingresa el elemento {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public int ObtenerMenor()
        {
            
        }
        public bool SeRepite()
        {
           
        }
        public void MostrarResultados()
        {
            
        }
        static void Main(string[] args)
        {
            Programa p = new Programa();
        }
    }
}

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
            int menorActual = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingresa un valor: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (vector[i] < menorActual)
                {
                    menorActual = vector[i];
                }
                else if (vector[i] == menorActual)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (vector[j] == vector[i])
                        {
                            Console.WriteLine("El valor menor se repite");
                            break;
                        }
                    }
                }
            }
        }
        
        public void obtenerMenor()
        {
            int menor = vector.Min();

            Console.WriteLine("Valor mínimo: " + menor);
            Console.WriteLine("  ");
        }
        static void Main(string[] args)
        {
            Programa p = new Programa();
            p.cargarElementos();
            p.obtenerMenor();

            Console.ReadKey();
        }
    }
}

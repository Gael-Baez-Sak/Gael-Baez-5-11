using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//Crear una matriz de 2 filas y 5 columnas.Realizar la carga de
//componentes por columna(es decir primero ingresar toda la primer
//columna, luego la segunda columna y así sucesivamente)
//Imprimir luego la matriz.
    internal class Program
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[2, 5];
            for(int f = 0; f < 2; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Ingrese componente: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void imprimirColumnas()
        {
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.WriteLine(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.imprimirColumnas();

            Console.ReadKey();
        }
    }
}

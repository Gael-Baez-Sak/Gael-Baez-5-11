using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Crear una matriz de n * m filas(cargar n y m por teclado) Imprimir los
    //cuatro valores que se encuentran en los vértices de la misma(mat[0][0]
    //etc.)
    internal class Program
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Ingrese cantidad de filas: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.WriteLine("Ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(1); f++)
            {
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    Console.WriteLine("Ingrese componente: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void imprimirVertices()
        {
            Console.WriteLine("Vertice 1: " + mat[0, 0]);
            Console.WriteLine("Vertice 2: " + mat[0, mat.GetLength(1) - 1]);
            Console.WriteLine("Vertice 3: " + mat[mat.GetLength(0) - 1, 0]);
            Console.WriteLine("Vertice 4: " + mat[mat.GetLength(0) - 1, mat.GetLength(1) - 1]);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.imprimirVertices();

            Console.ReadKey();
        }
    }
}

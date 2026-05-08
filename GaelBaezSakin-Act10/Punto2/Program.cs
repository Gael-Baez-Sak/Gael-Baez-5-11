using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Crear una matriz de n * m filas(cargar n y m por teclado) Intercambiar la
    //primer fila con la segunda.Imprimir luego la matriz.
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
        public void intercambiarColumn()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                int aux = mat[0, f];
                mat[0, f] = mat[1, f];
                mat[1, f] = aux;
            }
        }
        public void imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.intercambiarColumn();
            p.imprimir();
                
            Console.ReadKey();
        }
    }
}

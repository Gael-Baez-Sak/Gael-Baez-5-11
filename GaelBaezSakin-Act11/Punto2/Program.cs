using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
    //primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
    //(crearla sin la intervención del operador)
    //Realizar la carga por teclado e imprimir posteriormente.
    internal class Program
    {
        private int[][] mat;

        public void CargarIrregular()
        {
            mat = new int[5][];

            mat[0] = new int[1];
            mat[1] = new int[2];
            mat[2] = new int[3];
            mat[3] = new int[4];
            mat[4] = new int[5];
        }
        public void CargarDatos()
        {
            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write("Ingrese un numero: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f][c] = int.Parse(linea);
                }
            }
        }
        public void imprimir()
        {
            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write(mat[f][c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CargarIrregular();
            p.CargarDatos();
            p.imprimir();

            Console.ReadKey();
        }
    }
}

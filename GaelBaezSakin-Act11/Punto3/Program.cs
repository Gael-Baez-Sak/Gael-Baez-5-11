using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
    //empresa.
    //Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
    //irregular para cargar los días que han faltado cada empleado (cargar el número de día que
    //faltó)
    //Cada fila de la matriz representa los días de cada empleado.
    //a.Mostrar los empleados con la cantidad de inasistencias.
    //b.Cuál empleado faltó menos días.
    internal class Program
    {
        private string[] empleados;
        private int[][] diasFaltados;
        private int[] cantidadFaltas;

        public void Cargar()
        {
            empleados = new string[3];
            diasFaltados = new int[3][];
            for(int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                empleados[f] = Console.ReadLine();
                Console.Write("Cuantos dias falto el empleado: ");
                string linea;
                linea = Console.ReadLine();
                int cantidadDias = int.Parse(linea);
                diasFaltados[f] = new int[cantidadDias];
                for(int c = 0; c < diasFaltados[f].Length; c++)
                {
                    Console.Write("Ingrese el numero del dia (de este mes) que falto: ");
                    linea = Console.ReadLine();
                    diasFaltados[f][c] = int.Parse(linea);
                }
                Console.WriteLine(" ");
            }
        }
        public void guardarCantFaltas()
        {
            cantidadFaltas = new int[3];
            for(int f = 0; f < diasFaltados.Length; f++)
            {
                cantidadFaltas[f] = diasFaltados[f].Length;
            }
        }
        public void empleadoMenosFaltas()
        {
            double men = cantidadFaltas[0];
            string nom = empleados[0];
            for (int f = 0; f < cantidadFaltas.Length; f++)
            {
                if (cantidadFaltas[f] < men)
                {
                    men = cantidadFaltas[f];
                    nom = empleados[f];
                }
            }
            Console.WriteLine("El empleado con menos faltas es: " + nom + " con " + men + " faltas.\n");
        }
        public void imprimir()
        {
            for(int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Empleado: " + empleados[f] + " Cantidad de faltas: " + cantidadFaltas[f]);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.guardarCantFaltas();
            p.empleadoMenosFaltas();
            p.imprimir();

            Console.ReadKey();
        }
    }
}

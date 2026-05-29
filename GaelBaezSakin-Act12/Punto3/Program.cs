using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Un chef instructor evalúa a 3 alumnos en un examen final.Cada alumno debe presentar
    //una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
    //● Definir un vector para los nombres de los alumnos.
    //● Definir una matriz irregular para cargar el puntaje obtenido(0 a 100) en cada plato
    //presentado.
    //● Métodos:
    //1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
    //de cada alumno.
    //2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
    //3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
    //4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado";
    //(promedio >= 70) o "Reprobado";.
    //5. Determinar quién obtuvo el puntaje individual más alto en un solo plato(el
    //valor máximo de la matriz).
    internal class Program
    {
        private string[] alumnos;
        private int[][] puntajes; 
        public void CargarAlumnosYCantidadPlatos()
        {
            alumnos = new string[3];
            puntajes = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre del alumno " + (i + 1) + ": ");
                alumnos[i] = Console.ReadLine();

                Console.Write("Cuantos platos debe presentar " + alumnos[i] + "?: ");
                int cantidadPlatos = int.Parse(Console.ReadLine());

                puntajes[i] = new int[cantidadPlatos];
            }
        }
        public void CargarPuntajes()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + alumnos[i]);
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.Write("  Puntaje del plato " + (j + 1) + ": ");
                    int nota = int.Parse(Console.ReadLine());

                    while (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("  [ERROR] El puntaje debe ser entre 0 y 100.");
                        Console.Write("  Reingrese puntaje del plato " + (j + 1) + ": ");
                        nota = int.Parse(Console.ReadLine());
                    }
                    puntajes[i][j] = nota;
                }
            }
        }
        public void MostrarListado()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Alumno " + alumnos[i] + ": ");
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.Write("[" + puntajes[i][j] + " pts] ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularPromediosYEstados()
        {
            for (int i = 0; i < 3; i++)
            {
                double suma = 0;
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    suma = suma + puntajes[i][j];
                }
                double promedio = suma / puntajes[i].Length;

                Console.Write("Alumno: " + alumnos[i] + " Promedio: " + promedio);

                if (promedio >= 70)
                {
                    Console.WriteLine(" Aprobado");
                }
                else
                {
                    Console.WriteLine(" Reprobado");
                }
            }
        }
        public void BuscarPuntajeMaximo()
        {
            int maxPuntaje = puntajes[0][0];
            string alumnoMaximo = alumnos[0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    if (puntajes[i][j] > maxPuntaje)
                    {
                        maxPuntaje = puntajes[i][j];
                        alumnoMaximo = alumnos[i];
                    }
                }
            }

            Console.WriteLine("El puntaje individual mas alto fue de: " + maxPuntaje + " puntos.");
            Console.WriteLine("Fue obtenido por el alumno: " + alumnoMaximo);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.CargarAlumnosYCantidadPlatos();
            p.CargarPuntajes();
            p.MostrarListado();
            p.CalcularPromediosYEstados();
            p.BuscarPuntajeMaximo();

            Console.ReadKey();

        }
    }
}

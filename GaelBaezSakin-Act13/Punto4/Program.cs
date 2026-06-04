using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Plantear una clase Alumno que tenga los atributos privados: nombre y un
    //vector de 4 notas.Definir un constructor que solicite el ingreso del nombre del
    //alumno y sus 4 calificaciones.
    //Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
    //Alumno.
    //Agregar los siguientes métodos:
    //a) Un método que imprima el nombre de cada alumno y su promedio.
    //b) Un método que muestre el nombre del alumno con el promedio más
    //alto.
    //c) Un método que indique qué alumnos tienen al menos una nota
    //desaprobada(nota menor a 6)

    class Alumno
    {
        private string nombre;
        private float[] notas;

        public Alumno()
        {
            notas = new float[4];

            Console.Write("Ingrese el nombre del alumno/a: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingresa tu puntuacion: ");
                string linea;
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }
        public void sacarPromedio()
        {
            float promedio;

            promedio = 0;

            for (int i = 0; i < 4; i++)
            {
                promedio = promedio + notas[i];
            }
            promedio = promedio / 4;
            Console.WriteLine("El promedio de las notas es: " + promedio);
            Console.WriteLine("  ");
        }
        public void TieneNotaDesaprobada()
        {
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] < 6)
                {
                    Console.Write("Esta desaprobado");
                }
                else{
                    Console.Write("Esta aprobado");
                }
            }
            
        }
    }

    class Curso
    {
        private Alumno[] alumnos;
        public Curso()
        {
            for (int i = 0; i < 3; i++)
            {
                ;
                alumnos[i] = new Alumno();
                Console.WriteLine();
            }
        }       
        static void Main(string[] args)
        {
        }
    }
}


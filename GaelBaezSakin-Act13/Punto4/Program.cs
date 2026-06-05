using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Plantear una clase Alumno que tenga los atributos privados: nombre y un
    //vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
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
        private int[] notas;

        public Alumno()
        {
            notas = new int[4];

            Console.Write("Ingrese el nombre del alumno/a: ");
            nombre = Console.ReadLine();
                
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese su nota: ");
                string linea;
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }
        public string devolverNombre()
        {
            return nombre;
        }
        public int[] devolverNotas()
        {
            return notas;
        }

    }
    class Curso
    {
        private Alumno[] alumnos;
        public Curso()
        {
            alumnos = new Alumno[3];

            for (int i = 0; i < 3; i++)
            {
                alumnos[i] = new Alumno();

            }
            Console.WriteLine(alumnos[0].devolverNotas());
        }
        public void TieneNotaDesaprobada()
        {
            for (int i = 0; i < 3; i++)
            {
                int[] notasAlumno = alumnos[i].devolverNotas();
                bool tieneDesaprobada = false;

                for (int j = 0; j < 4; j++)
                {
                    if (notasAlumno[j] < 6)
                    {
                        tieneDesaprobada = true;
                        break;
                    }
                }
                if (tieneDesaprobada)
                {
                    Console.WriteLine($"{alumnos[i].devolverNombre()} tiene al menos una nota desaprobada.");
                }
            }

        }
        public void sacarPromedio()
        {
            for (int i = 0; i < 3; i++)

            {
                int suma = 0;
                int[] notasAlumno = alumnos[i].devolverNotas();

                for (int j = 0; j < 4; j++)
                {
                    suma += notasAlumno[j];
                }

                float promedio = suma / 4;
                Console.WriteLine("El promedio de las notas de " + alumnos[i].devolverNombre() + " es: " + promedio);
                Console.WriteLine("  ");
            }
        }
        public void promedioMasAlto()
        {
            float maxPromedio = 0;
            string nombreMaxAlumno = "";

            for (int i = 0; i < 3; i++)
            {
                int suma = 0;
                int[] notasAlumno = alumnos[i].devolverNotas();

                for (int j = 0; j < 4; j++)
                {
                    suma += notasAlumno[j];
                }
                float promedio = suma / 4;
                if (promedio > maxPromedio)
                {
                    maxPromedio = promedio;
                    nombreMaxAlumno = alumnos[i].devolverNombre();
                }
            }

            Console.WriteLine($"El alumno con el promedio más alto es {nombreMaxAlumno} con un promedio de {maxPromedio}.");
            Console.WriteLine(" ");
        }
        public void mostrarDatos()
        {
            for (int i = 0; i < 3; i++)
            {
                alumnos[i].devolverNombre();
            }
        }

        public void mostrarNotas()
        {
            for (int i = 0; i < 3; i++)
            {
                alumnos[i].devolverNotas();
            }
        }
            static void Main(string[] args)
            {
            Curso c = new Curso();
            c.sacarPromedio(); 
            c.promedioMasAlto();
            c.TieneNotaDesaprobada();
            c.mostrarDatos();
            c.mostrarNotas();

            Console.ReadKey();
            }
        }
    }

